using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = GetPeopleStrings();

            foreach (string person in people)
            {
                Console.WriteLine($"Hello { person }");
            }

            Console.ReadLine();

            List<PersonModel> peopleModels = GetPeopleModels();
            
            foreach (PersonModel person in peopleModels)
            {
                Console.WriteLine($"Hello { person.FirstName } { person.LastName }");
            }

            Console.ReadLine();
        }

        private static List<PersonModel> GetPeopleModels()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            output.Add(new PersonModel { FirstName = "Bill", LastName = "McCoy" });
            output.Add(new PersonModel { FirstName = "Mary", LastName = "Jones" });
            output.Add(new PersonModel { FirstName = "Sue", LastName = "Smith" });

            return output;
        }

        private static List<string> GetPeopleStrings()
        {
            List<string> output = new List<string>();

            output.Add("John");
            output.Add("Mary");
            output.Add("Sue");
            output.Add("Greg");
            output.Add("Yolada");
            output.Add("Jose");
            output.Add("Bill");

            return output;
        }
    }
}
