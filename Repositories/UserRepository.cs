﻿using Apteka.Enums;
using Apteka.IRepositories;
using Apteka.Models;
using Apteka.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Create(User user)
        {
            // jsonni tekst shaklda olish
            string json = File.ReadAllText(Constants.UserJsonPath);
            IList<User> users = JsonConvert.DeserializeObject<IList<User>>(json);
            users.Add(user);

            json = JsonConvert.SerializeObject(users);
            File.WriteAllText(Constants.UserJsonPath, json);
            
            return user;
        }

        public User Login(string login, string password)
        {
            string[] files = Directory.GetFiles(Constants.UserDbPath);

            foreach (string file in files)
            {
                string[] userDetails = File.ReadAllLines(file);
                string userLogin = userDetails[4];
                string userPassword = userDetails[5];

                if (login == userLogin && password == userPassword)
                {
                    return new User
                    {
                        Id = Guid.Parse(userDetails[0]),
                        FirstName = userDetails[1],
                        LastName = userDetails[2],
                        Role = (UserRole)Enum.Parse(typeof(UserRole), userDetails[3]),
                        Login = userDetails[4],
                        Password = userDetails[5]
                    };
                }
            }
            
            return null;
        }
    }
}
