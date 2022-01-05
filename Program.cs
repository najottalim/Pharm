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
        static void Main(string[] args)
        {
            string json = File.ReadAllText(Constants.UserJsonPath);

            var universites = JsonConvert.DeserializeObject<List<dynamic>>(json);

            List<dynamic> names = universites.Select(x => x).ToList();

            Console.WriteLine();
        }
    }
}
