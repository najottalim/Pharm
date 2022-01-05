using Apteka.Enums;
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
            var users = GetAll();
            users.Add(user);

            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(Constants.UserJsonPath, json);
            
            return user;
        }

        public IList<User> GetAll()
        {
            string json = File.ReadAllText(Constants.UserJsonPath);
            return JsonConvert.DeserializeObject<IList<User>>(json);
        }

        public User Login(string login, string password)
        { 
            return GetAll().FirstOrDefault(p => p.Login == login && p.Password == password);
        }
    }
}
