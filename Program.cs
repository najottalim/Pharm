using Apteka.Enums;
using Apteka.IRepositories;
using Apteka.Models;
using Apteka.Models.Restaurant;
using Apteka.Repositories;
using Apteka.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            string json = File.ReadAllText(Constants.KitchenJsonPath);
            IList<Kitchen> kitchens = JsonConvert.DeserializeObject<IList<Kitchen>>(json);

            var res =JObject.Parse(json)["user"]["address"];

            foreach (var kitchen in kitchens)
            {
                Console.WriteLine(kitchen.FoodItems[0].FoodName);
            }

        }
    }
}
