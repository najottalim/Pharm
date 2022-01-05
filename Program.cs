using Apteka.Enums;
using Apteka.IRepositories;
using Apteka.Models;
using Apteka.Repositories;
using Apteka.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Apteka
{
    internal class Program
    {
        private static IUserRepository _userRepository = new UserRepository();
        static void Main(string[] args)
        {


            //var user = _userRepository.Create(new User
            //{
            //    FirstName = "Ahmadjon",
            //    LastName = "Sirojiddinov",
            //    Login = "admin",
            //    Password = "12345"
            //});   
        }
    }
}
