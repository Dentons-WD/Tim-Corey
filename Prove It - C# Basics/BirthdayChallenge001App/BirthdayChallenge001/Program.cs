using System;
using System.Globalization;
using System.Security.Cryptography;

namespace BirthdayChallenge001
{
    class Program
    {
        
        // GOAL 
        // Identify how old a person is by using their date of
        // birth. List how old they are in years (round down),
        // months, and days.

        // BONUS
        // Calculate how long it will be until the person’s next
        // birthday. Round months to the nearest whole
        // number. Then calculate the number of weekends
        // until their birthday.

        static void Main(string[] args)
        {
            string input = string.Empty;
            DateTime birthday = new DateTime();
            TimeSpan age = new TimeSpan();
            bool validDate = false;

            Console.WriteLine("Please enter your Date Of Birth in the following format: dd-MM-yyyy");

            do
            {
                input = Console.ReadLine();
                validDate = DateTime.TryParseExact(input, "dd-MM-yyyy", null, DateTimeStyles.None, out birthday);

                if (validDate != true)
                {
                    Console.WriteLine($"'{ input } is invalid, please enter a date in the format: dd-MM-yyyy'");
                }

                if (validDate == true)
                {
                    if (DateTime.Compare(DateTime.Today, birthday) <= 0)
                    {
                        validDate = false;
                        Console.WriteLine("Your birthday cannot be in the future, please enter a date in the format: dd-MM-yyyy");
                    }
                }
            } while (validDate != true);

            birthday = birthday.Date;

            // GOAL
            //age = DateTime.Today.Subtract(birthday);

            //int yearsOld = 0;
            //yearsOld = (int)Math.Floor((age.TotalDays / 365.25));

            //int monthsOld = 0;
            //monthsOld = (int)Math.Floor((age.TotalDays / 365.25) * 12);

            //int daysOld = 0;
            //daysOld = (int)Math.Round((age.TotalDays), 0);

            //Console.WriteLine($"You are { yearsOld } year/s old.");
            //Console.WriteLine($"You are { monthsOld } month/s old.");
            //Console.WriteLine($"You are { daysOld } day/s old.");

            // BONUS
            DateTime nextBirthday = birthday.AddYears(DateTime.Today.Year - birthday.Year);

            if (nextBirthday.Month > DateTime.Now.Month || ((nextBirthday.Month == DateTime.Now.Month) && (nextBirthday.Day > DateTime.Now.Day)))
            {
                nextBirthday = nextBirthday.AddYears(0);
            }
            else
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan timeTillNextBirthday = nextBirthday.Subtract(DateTime.Today);

            int monthsTillNextBirthday = 0;
            monthsTillNextBirthday = (int)Math.Floor((timeTillNextBirthday.TotalDays / 365.25) * 12);

            int daysTillNextBirthday = 0;
            daysTillNextBirthday = (int)Math.Round(timeTillNextBirthday.TotalDays, 0);

            int weekendsTillNextBirthday = 0;
            weekendsTillNextBirthday = (int)Math.Floor((timeTillNextBirthday.TotalDays / 365.25) * 52);

            if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday)
            {
                weekendsTillNextBirthday += 1;
            }

            Console.WriteLine($"There are { monthsTillNextBirthday } months till your birthday.");
            Console.WriteLine($"There are { daysTillNextBirthday } days till your birthday.");
            Console.WriteLine($"There are { weekendsTillNextBirthday } weekends till your birthday.");

            Console.ReadLine();
        }
    }
}
