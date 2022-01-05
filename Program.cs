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

            List<University> universites = JsonConvert.DeserializeObject<List<University>>(json);
            universites.Add(new University
            {
                Name = ".NET Uzbekistan",
                Country = "Uzbekistan",
                Domains = new List<string>
                {
                    "dot-net.uz",
                    "visualstudio.uz"
                }
            });

            string result = JsonConvert.SerializeObject(universites);
            File.WriteAllText(Constants.UserJsonPath, result);

            Console.WriteLine("done");
        }
    }
}
