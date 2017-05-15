using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.Data;
using Service.Models;
using System.Data.Entity.Validation;
using System.Data.Entity.Core;

namespace Service.Implementations
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class Server : IServer
    {
        // SŁOWNIK ZAWIERAJĄCY PARY POŁĄCZENIE <-> LOGIN
        private Dictionary<IServerCallback, string> _users = new Dictionary<IServerCallback, string>();

        // SŁOWNIK ZAWIERAJĄCY PARY POŁĄCZENIE <-> LOGIN DLA UŻYTKOWNIKÓW PROWADZĄCYCH AKTUALNIE ROZMOWY PRYWATNE
        private Dictionary<IServerCallback, string> _privateUsers = new Dictionary<IServerCallback, string>();

        public void Login(LoginUser user)
        {
            // LISTA ZAWIERAJĄCA SPIS AKTUALNIE ZALOGOWANYCH UŻYTKOWNIKÓW
            IList<string> users = new List<string>();

            // LISTA ZAWIERAJĄCA BINARNĄ REPREZENTACJĘ AWATARÓW
            List<byte[]> avatars = new List<byte[]>();

            Console.WriteLine($"Żądanie logowania użytkownika: {user.Login} {user.Password}");

            using (var db = new ServiceDbContext())
            {
                try
                {
                    bool userExists = (from entity in db.Users where entity.Login == user.Login && entity.Password == user.Password select entity).Any();

                    if (userExists)
                    {
                        var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

                        // SPRAWDZENIE CZY UŻYTKOWNIK JEST JUŻ ZALOGOWANY
                        if (_users.ContainsValue(user.Login))
                        {
                            Console.WriteLine("User already logged in");
                            context.LoginErrorCallback("User already logged in");
                        }
                        else
                        {
                            // SPRAWDZENIE CZY W DANEJ INSTANCJI APLIKACJI UŻYTKOWNIK ZOSTAŁ JUŻ ZALOGOWANY
                            if (_users.ContainsKey(context))
                            {
                                Console.WriteLine("There is one logged user from the same application instance already");
                                context.LoginErrorCallback("There is one logged user from the same application instance already");
                            }
                            // JEśLI NIE, WÓWCZAS MOŻLIWE JEST LOGOWANIE
                            else
                            {
                                _users[context] = user.Login;

                                // Dodawanie do listy awatarów
                                foreach (var item in _users.Values)
                                {
                                    byte[] avatar = (from entity in db.Users where entity.Login == item select entity.Avatar).First();
                                    avatars.Add(avatar);
                                    users.Add(item);
                                }

                                // Zamiana listy na tablicę dwuwymiarową
                                byte[][] avatarArray = avatars.Select(a => a.ToArray()).ToArray();

                                foreach (var item in _users.Keys)
                                {
                                    item.UpdateUsersList(users, avatarArray);
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().LoginErrorCallback("Login or password incorrect");
                    }
                }
                catch(Exception ex)
                {
                    OperationContext.Current.GetCallbackChannel<IServerCallback>().LoginErrorCallback(ex.Message);
                }
            }
        }

        public void Register(RegisterUser user)
        {
            Console.WriteLine($"Żądanie rejestracji nowego użytkownika: {user.Login} {user.Password} {user.PasswordConfirm} " +
                $"{user.Name} {user.Surname} {user.Sex} {user.Age}");

            User dbUser = new User
            {
                Login = user.Login,
                Password = user.Password,
                PasswordConfirm = user.PasswordConfirm,
                Name = user.Name,
                Surname = user.Surname,
                Sex = user.Sex,
                Age = user.Age,
                Avatar = user.Avatar
            };

            using (var db = new ServiceDbContext())
            {
                bool userExists = false;

                userExists = (from entity in db.Users where entity.Login == dbUser.Login select entity).Any();

                if (!userExists)
                {
                    try
                    {
                        db.Users.Add(dbUser);
                        db.SaveChanges();
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify("OK");
                    }
                    catch(DbEntityValidationException ex)
                    {
                        db.Users.Remove(dbUser);
                        string message = "";

                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach(var validationError in validationErrors.ValidationErrors)
                            {
                                message += $"{validationError.ErrorMessage}{Environment.NewLine}";    
                            }
                        }

                        Console.WriteLine(message);
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify($"{message}");
                    }
                    catch(EntityException ex)
                    {
                        Console.WriteLine($"Wystąpił błąd {ex.InnerException.Message}");
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify($"{ex.InnerException.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wystąpił błąd {ex.InnerException.Message}");
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify($"{ex.InnerException.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Podany login jest już zajęty");
                    OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify("Podany login jest już zajęty");
                }
            }

        }

        public void SendPublicMessage(string message)
        {
            Console.WriteLine($"Publiczna wiadomość: {message}");
            var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

            foreach (var item in _users.Keys)
            {
                item.UpdatePublicChatTextBox(_users[context], message);
            }
        }

        public void SendPrivateMessage(string sender, string receiver, string message)
        {

            Console.WriteLine($"Nadawca: {sender} Odbiorca: {receiver} Wiadomość: {message}");
            var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

            // Jeśli użytkownik wysyła pierwszy raz wiadomość prywatną, należy dodać go do słownika
            if (!_privateUsers.ContainsKey(context))
            {
                _privateUsers[context] = sender;
            }

            // Sprawdzenie, czy odbiorca ma już otwarty kanał, jeśli nie wiadomość zostanie wysłana głownym kanałem
            if(_privateUsers.ContainsValue(receiver))
            {
                Console.WriteLine("Użytkownik ma już otwarty kanał");
                foreach(var key in _privateUsers.Keys)
                {
                    if (_privateUsers[key] == receiver)
                    {
                        key.UpdatePrivateChatForm(sender, message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Użytkownik nie ma otwartego kanału");
                
                // Znalezienie głównego kanału dla odbiorcy
                foreach(var key in _users.Keys)
                {
                    if (_users[key] == receiver)
                    {
                        Console.WriteLine("Znaleziono kanał");
                        key.OpenPrivateChatForm(sender, receiver, message);
                        break;
                    }
                }
            }
        }

        public void ExitPrivateMessage(string sender, string[] users, string message)
        {
            Console.WriteLine($"Zakończenie rozmowy prywatnej przez {sender}");
            Console.WriteLine("Wiadomość zostanie rozesłana do użytkowników");
            foreach(var user in users)
            {
                Console.WriteLine(user);
            }

            var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

            // Rozesłanie informacji do użytkowników prowadzących rozmowę prywatną z danym użytkownikiem
            foreach(var user in users)
            {
                foreach(var key in _privateUsers.Keys)
                {
                    if (_privateUsers[key].Equals(user))
                    {
                        key.UpdateLogoutPrivateChatForm(sender, users, message);
                        break;
                    }
                }
            }

            // Usunięcie użytkownika z listy użytkowników prowadzących prywatne rozmowy
            _privateUsers.Remove(context);

            // Zamknięcie kanału użytkownika kończącego rozmowę prywatną
            var channel = (ICommunicationObject)context;
            channel.Close();
        }

        public void Logout()
        {
            IList<string> users = new List<string>();

            // LISTA ZAWIERAJĄCA BINARNĄ REPREZENTACJĘ AWATARÓW
            List<byte[]> avatars = new List<byte[]>();

            var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

            Console.WriteLine($"Żądanie wylogowania użytkownika: {_users[context]}");

            // Przypisanie nazwy użytkownika, który aktualnie się wylogowuje
            var login = _users[context];

            // Usunięcie elementu z listy zarejestrowanych użytkowników
            _users.Remove(context);

            using (var db = new ServiceDbContext())
            {
                foreach (var item in _users.Values)
                {
                    byte[] avatar = (from entity in db.Users where entity.Login == item select entity.Avatar).First();
                    avatars.Add(avatar);
                    users.Add(item);
                }

                // Zamiana listy na tablicę dwuwymiarową
                byte[][] avatarArray = avatars.Select(a => a.ToArray()).ToArray();

                foreach (var item in _users.Keys)
                {
                    item.UpdateUsersList(users, avatarArray);
                }


            }

                // Wyczyszczenie listy zalogowanych użytkowników u klienta, który się wylogował
                context.UpdateLogoutUsersList();

            // Wyczyszczenie okna rozmowy publicznej
            context.UpdateLoginPublicChatTextBox();

            // Zamknięcie połączenia z głównym oknem aplikacji
            //var connection = (ICommunicationObject)context;
            //connection.Close();

            // Zaktualizowanie listy obecnie zalogowanych użytkowników u pozostałych podłączonych klientów
            //foreach (var key in _users.Keys)
            //{
            //    users.Add(_users[key]);
            //}

            foreach (var item in _users.Keys)
            {
                   
                item.UpdatePublicChatTextBox(login, $"LOGGED OUT AT {DateTime.Now.ToString()}");
            }
        }

        public void ExitApplication(string sender, string message)
        {
            var context = OperationContext.Current.GetCallbackChannel<IServerCallback>();

            // Usunięcie użytkownika z listy aktywnych użytkowników
            foreach(var key in _users.Keys)
            {
                if (!_users[key].Equals(sender))
                {
                    Console.WriteLine($"Użytkownik {sender} zakończył pracę z aplikacją");
                    key.UpdateExitMainForm(sender, message);
                }
                /*else
                {
                    _users.Remove(key);
                }*/
            }

            // Usunięcie użytkownika z listy aktywnych użytkowników
            foreach(var key in _users.Keys)
            {
                if(_users[key].Equals(sender))
                {
                    _users.Remove(key);
                    break;
                }
            }

            // Zamknięcie połączenie z głównym oknem aplikacji
            var channel = (ICommunicationObject)context;
            channel.Close();
        }
    }
}
