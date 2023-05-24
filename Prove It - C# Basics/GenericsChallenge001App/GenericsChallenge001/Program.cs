using GenericsChallenge001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GOAL
// Create a method that takes in two List<T> lists, intermixes
// them, and then returns a new list. Alternate
// pulling items from each list starting with the bigger
// list. Make sure the method can take in any List<T>.
//
// BONUS
// Create another generics method that takes in two
// generic objects (of the same or different types). Make
// sure each object that is passed in has a Title property
// in it. Return the object with the longer title.


namespace GenericsChallenge001
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> listOne = new List<string>
            //{
            //    "Bob",
            //    "James",
            //    "Matt",
            //    "Paul",
            //    "David"
            //};

            //List<string> listTwo = new List<string>
            //{
            //    "Sara",
            //    "Victoria",
            //    "Jennifer",
            //    "Vivienne",
            //    "Mary",
            //    "Penny"
            //};


            //List<string> mixedList = GenericsMethods.InterMixLists(listOne, listTwo);

            //foreach (string s in mixedList)
            //{
            //    Console.WriteLine(s);
            //}

            PersonModel person1 = new PersonModel
            {
                Title = "Mr Jonathan Bloggs",
                FirstName = "Joe",
                LastName = "Bloggs"
            };

            EmployeeModel employee = new EmployeeModel
            {
                Title = "Junior Doctor",
                Person = new PersonModel
                {
                    Title = "Mrs",
                    FirstName = "Jane",
                    LastName = "Doe"
                },
                StartDate = DateTime.Now,
            };

            var output = GenericsMethods.ReturnObjectWithLongestTitle<PersonModel, EmployeeModel>(person1, employee);

            Console.WriteLine(output.ToString());

            Console.ReadLine();
        }
    }
}
