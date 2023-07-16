using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataAccess
    {
        Random rnd = new Random();
        string[] streetAddresses = new string[] { "101 State Street", "425 Oak Avenue", "7 Wallace Way", "928 Edwards Court", "29 Main Avenue" };
        string[] cities = new string[] { "Springfield", "Wilshire", "Alexandria", "Franklin", "Clinton", "Fairview", "Madison" };
        string[] states = new string[] { "WI", "GA", "PA", "TX", "CA", "IL", "WA", "VA", "FL", "OK", "AZ" };
        string[] zipCodes = new string[] { "14121", "08904", "84732", "23410", "60095", "60618", "10456", "00926", "08701", "90280", "92335", "79936" };

        string[] firstNames = new string[] { "Bob", "Sue", "Carla", "Frank", "Monique", "Carlton", "Miguel", "Daniel", "Santiago", "John", "Robert" };
        string[] lastNames = new string[] { "Smith", "Jones", "Garcia", "Miller", "Thomas", "Lee", "Taylor", "Wilson", "Martinez", "Davis", "Hernandez" };
        bool[] aliveStatuses = new bool[] { true, false };
        DateTime lowEndDate = new DateTime(1943, 1, 1);
        int daysFromLowDate;

        public DataAccess()
        {
            daysFromLowDate = (DateTime.Today - lowEndDate).Days;
        }

        public List<PersonModel> GetPeople(int total = 10)
        {
            List<PersonModel> output = new List<PersonModel>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetPerson(i + 1));
            }

            return output;
        }

        private PersonModel GetPerson(int id)
        {
            PersonModel output = new PersonModel();

            output.PersonId = id;
            output.FirstName = GetRandomItem(firstNames);
            output.LastName = GetRandomItem(lastNames);
            output.IsAlive = GetRandomItem(aliveStatuses);
            output.DateOfBirth = GetRandomDate();
            output.Age = GetAgeInYears(output.DateOfBirth);
            output.AccountBalance = ((decimal)rnd.Next(1, 1000000) / 100);

            int addressCount = rnd.Next(1, 5);

            for (int i = 0; i < addressCount; i++)
            {
                output.Addresses.Add(GetAddress(((id - 1) * 5) + i + 1));
            }

            return output;
        }

        private AddressModel GetAddress(int id)
        {
            AddressModel output = new AddressModel();

            output.AddressId = id;
            output.StreetAddress = GetRandomItem(streetAddresses);
            output.City = GetRandomItem(cities);
            output.State = GetRandomItem(states);
            output.ZipCode = GetRandomItem(zipCodes);

            return output;
        }

        private T GetRandomItem<T>(T[] data)
        {
            return data[rnd.Next(0, data.Length)];
        }

        private DateTime GetRandomDate()
        {
            return lowEndDate.AddDays(rnd.Next(daysFromLowDate));
        }

        private int GetAgeInYears(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
