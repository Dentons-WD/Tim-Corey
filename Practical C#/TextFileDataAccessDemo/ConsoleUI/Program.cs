using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demos\Test.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Sue,Storm,www.stormy.com");

            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }

            Console.WriteLine("Read from text file");
            foreach (var person in people) 
            {
                // person.FirstName + " " + person.LastName + ": " + person.Url
                Console.WriteLine($"{ person.FirstName } { person.LastName }: { person.Url }");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test.com" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{ person.FirstName },{ person.LastName },{ person.Url }");
            }
            
            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();
        }
    }
}
