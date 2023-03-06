using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Getting Started Group!");

            string connectionString = Configuration.GetConnectionString("Default");
            Console.WriteLine($"Connection String: { connectionString }");

            string otherInfo = Configuration.GetSection("OtherInfo").Value;
            Console.WriteLine($"Other Info: { otherInfo }");

            string demo1 = Configuration.GetSection("Demos").GetSection("Demo1").Value;
            Console.WriteLine($"Demo 1: { demo1 }");
        }
    }
}
