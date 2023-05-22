using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyObjectsChallenge001
{
    class Program
    {

        // GOAL
        // In the example application, turn secondPerson into a
        // copy of the firstPerson object and then change the
        // required items. Run the application to make sure the
        // statements are all true.

        // BONUS
        // Identify and implement a second way to copy
        // firstPerson into secondPerson. Make sure either way
        // you make the copy, the statements are all true when
        // you run it.

        static void Main(string[] args)
        {
            PersonModel firstPerson = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
                DateOfBirth = new DateTime(1998, 7, 19),
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        StreetAddress = "101 State Street",
                        City = "Salt Lake City",
                        State = "UT",
                        ZipCode = "76321"
                    },
                    new AddressModel
                    {
                        StreetAddress = "842 Lawrence Way",
                        City = "Jupiter",
                        State = "FL",
                        ZipCode = "22558"
                    }
                }
            };

            // Creates a second PersonModel object
            PersonModel secondPerson = null;

            // Set the value of the secondPerson to be a copy of the firstPerson

            // GOAL
            secondPerson = new PersonModel
            {
                FirstName = firstPerson.FirstName,
                LastName = firstPerson.LastName,
                DateOfBirth = firstPerson.DateOfBirth,
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        StreetAddress = firstPerson.Addresses[0].StreetAddress,
                        City = firstPerson.Addresses[0].City,
                        State = firstPerson.Addresses[0].State,
                        ZipCode = firstPerson.Addresses[0].ZipCode
                    },
                    new AddressModel
                    {
                        StreetAddress = firstPerson.Addresses[1].StreetAddress,
                        City = firstPerson.Addresses[1].City,
                        State = firstPerson.Addresses[1].State,
                        ZipCode = firstPerson.Addresses[1].ZipCode
                    }
                }
            };

            // BONUS
            // ?

            // Update the secondPerson's FirstName to "Bob" 
            // and change the Street Address for each of Bob's addresses
            // to a different value

            // GOAL
            secondPerson.FirstName = "Bob";
            secondPerson.Addresses[0].StreetAddress = "99 Steak Street";
            secondPerson.Addresses[1].StreetAddress = "200 Hepburn Way";

            // Ensure that the following statements are true
            Console.WriteLine($"{ firstPerson.FirstName } != { secondPerson.FirstName }");
            Console.WriteLine($"{ firstPerson.LastName } == { secondPerson.LastName }");
            Console.WriteLine($"{ firstPerson.DateOfBirth.ToShortDateString() } == { secondPerson.DateOfBirth.ToShortDateString() }");
            Console.WriteLine($"{ firstPerson.Addresses[0].StreetAddress } != { secondPerson.Addresses[0].StreetAddress }");
            Console.WriteLine($"{ firstPerson.Addresses[0].City } == { secondPerson.Addresses[0].City }");
            Console.WriteLine($"{ firstPerson.Addresses[1].StreetAddress } != { secondPerson.Addresses[1].StreetAddress }");
            Console.WriteLine($"{ firstPerson.Addresses[1].City } == { secondPerson.Addresses[1].City }");

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    }

    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
