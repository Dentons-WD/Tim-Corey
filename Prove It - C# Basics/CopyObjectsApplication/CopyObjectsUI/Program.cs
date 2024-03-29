﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyObjectsUI
{
    class Program
    {
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

            // First method
            //string temporaryPerson = JsonConvert.SerializeObject(firstPerson);
            //secondPerson = JsonConvert.DeserializeObject<PersonModel>(temporaryPerson);

            // Second method
            secondPerson = new PersonModel(firstPerson);

            // Update the secondPerson's FirstName to "Bob" 
            // and change the Street Address for each of Bob's addresses
            // to a different value

            secondPerson.FirstName = "Bob";
            secondPerson.Addresses[0].StreetAddress = "4150 Mockingbird Lane";
            secondPerson.Addresses[1].StreetAddress = "9000 Wilmingon Ave";

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

        public PersonModel()
        {
            
        }

        public PersonModel(PersonModel personToCopy)
        {
            FirstName = personToCopy.FirstName;
            LastName = personToCopy.LastName;
            DateOfBirth = personToCopy.DateOfBirth;
            foreach (AddressModel originalAddress in personToCopy.Addresses)
            {
                AddressModel newAddress = new AddressModel(originalAddress);
                Addresses.Add(newAddress);
            }
        }
    }

    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public AddressModel()
        {
            
        }

        public AddressModel(AddressModel addressToCopy)
        {
            StreetAddress = addressToCopy.StreetAddress;
            City = addressToCopy.City;
            State = addressToCopy.State;
            ZipCode = addressToCopy.ZipCode;
        }
    }
}
