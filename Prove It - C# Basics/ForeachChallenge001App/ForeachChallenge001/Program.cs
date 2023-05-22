using ForeachChallenge001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ForeachChallenge001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Goal();
            Bonus();

            Console.ReadLine();
        }

        /// <summary>
        /// Create a Console app that has a List&lt;string&gt; populated 
        /// with a set of names. Loop through the names using
        /// the foreach. For every name, print it to the console.
        /// </summary>
        public static void Goal()
        {
            List<string> names = new List<string>
            {
                "Bob",
                "Sophie",
                "James",
                "Tim",
                "Candice"
            };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Instead of strings, make a class and create a set of
        /// instances of that class instead. The class should store
        /// first and last names. Use those properties when
        /// printing out the message on the console.
        /// </summary>
        public static void Bonus()
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel
                {
                    FirstName = "Tim",
                    LastName = "Corey"
                },
                new PersonModel
                {
                    FirstName = "Tom",
                    LastName = "Jones"
                },
                new PersonModel
                {
                    FirstName = "Zebediah",
                    LastName = "Roundtree"
                }
            };

            foreach (PersonModel person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }");
            }
        }
    }
}
