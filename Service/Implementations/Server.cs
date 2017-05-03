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
        // SŁOWNIK ZAWIERAJĄCY PAWY POŁĄCZENIE <-> LOGIN
        private Dictionary<IServerCallback, string> _users = new Dictionary<IServerCallback, string>();

        public void Login(LoginUser user)
        {
            // LISTA ZAWIERAJĄCA SPIS AKTUALNIE ZALOGOWANYCH UŻYTKOWNIKÓW
            IList<string> users = new List<string>();

            Console.WriteLine($"Żądanie logowania użytkownika: {user.Login} {user.Password}");

            using (var db = new ServiceDbContext())
            {
                try
                {
                    bool userExists = (from entity in db.Users where entity.Login == user.Login && entity.Password == user.Password select entity).Any();

                    if (userExists)
                    {
                        if (_users.ContainsValue(user.Login))
                        {
                            OperationContext.Current.GetCallbackChannel<IServerCallback>().LoginErrorCallback("User already logged in");
                        }
                        else
                        {
                            var connection = OperationContext.Current.GetCallbackChannel<IServerCallback>();

                            _users[connection] = user.Login;

                            foreach (var item in _users.Values)
                            {
                                users.Add(item);
                            }

                            connection.LoginCallback(users);
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
                Age = user.Age
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
    }
}
