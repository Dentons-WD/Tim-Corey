using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //Configuration = builder.Build();

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello Getting Started Group!");

            //string connectionString = Configuration.GetConnectionString("Default");
            //Console.WriteLine($"Connection String: { connectionString }");

            //string otherInfo = Configuration.GetSection("OtherInfo").Value;
            //Console.WriteLine($"Other Info: { otherInfo }");

            //string demo1 = Configuration.GetSection("Demos").GetSection("Demo1").Value;
            //Console.WriteLine($"Demo 1: { demo1 }");

            // .\Logs\LogFile.txt
            string path = Path.Combine(".", "Logs");
            string fullFile = Path.Combine(path, "LogFile.txt");

            Directory.CreateDirectory(path);

            List<string> logs = new List<string>
            {
                "This is my first log entry",
                "This is my second log entry",
                "Isn't he creative"
            };

            File.WriteAllLines(fullFile, logs);

            foreach (string log in File.ReadAllLines(fullFile))
            {
                Console.WriteLine(log);
            }
        }
    }
}
