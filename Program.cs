using Apteka.Enums;
using Apteka.IRepositories;
using Apteka.Models;
using Apteka.Repositories;
using System;

namespace Apteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mock Data
            //User user = new User
            //{
            //    FirstName = "Ahmadjon",
            //    LastName = "Sirojiddinov",
            //    Login = "test",
            //    Password = "123456",
            //    Role = UserRole.User
            //};
            #endregion

            IUserRepository userRepo = new UserRepository();
            //var result = userRepo.Create(user);

            string login = Console.ReadLine();
            string password = Console.ReadLine();
            User result = userRepo.Login(login, password);

            if(result == null)
                Console.WriteLine("Bunday foydalanuvchi mavjud emas");
            else
                Console.WriteLine(result.ToString());
        }
    }
}
