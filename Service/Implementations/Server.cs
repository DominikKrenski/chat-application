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
        public void Register(RegisterUser user)
        {
            Console.WriteLine($"Żądanie rejestracji nowego użytkownika: {user.Login} {user.Password} {user.PasswordConfirm}" +
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
                        Console.WriteLine($"Wystąpił błąd {ex.Message}");
                        OperationContext.Current.GetCallbackChannel<IServerCallback>().RegisterNotify($"{ex.Message}");
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
