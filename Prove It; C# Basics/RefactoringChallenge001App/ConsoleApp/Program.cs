using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Data;
using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string actionToTake = "";
            string connectionString = ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString;

            SystemUserData data = new SystemUserData(new SqlDataAccess());

            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                actionToTake = Console.ReadLine();

                switch (actionToTake.ToLower())
                {
                    case "display":

                        var records = data.GetSystemUsers();

                        Console.WriteLine();

                        foreach (var record in records)
                        {
                            Console.WriteLine($"{ record.FirstName } { record.LastName }");
                        }

                        Console.WriteLine();
                        break;
                    case "add":
                        Console.Write("What is the first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("What is the last name: ");
                        string lastName = Console.ReadLine();

                        SystemUserModel user = new SystemUserModel
                        {
                            FirstName = firstName,
                            LastName = lastName
                        };

                        data.InsertSystemUser(user);

                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (actionToTake.ToLower() != "quit");
        }
    }
}
