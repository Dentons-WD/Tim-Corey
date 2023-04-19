using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge001
{
    public static class Goal
    {
        public static void DateSequence()
        {
            string input = "";
            bool validDate = false;
            DateTime date = new DateTime();
            int daysAgo = 0;
            string dayOrDays = "";

            Console.WriteLine("Please enter a past date:");

            do
            {
                input = Console.ReadLine();
                validDate = DateTime.TryParse(input, out date);

                if (validDate != true)
                {
                    Console.WriteLine($"'{input}' is in a invalid format.");
                    Console.WriteLine("Please try again:");
                }
                else if (date.CompareTo(DateTime.Today) >= 0)
                {
                    validDate = false;

                    Console.WriteLine($"'{input}' is in the future.");
                    Console.WriteLine("Please try again:");
                }

            } while (validDate != true);

            daysAgo = DateTime.Today.Subtract(date).Duration().Days;

            if (daysAgo > 1)
            {
                dayOrDays = "days";
            }
            else
            {
                dayOrDays = "day";
            }

            Console.WriteLine($"{input} was {daysAgo} {dayOrDays} ago.");
        }

        public static void TimeSequence()
        {
            string input = "";
            bool validTime = false;
            DateTime time = new DateTime();
            TimeSpan timeSpan = new TimeSpan();
            string dayOrDays = "";

            Console.WriteLine("Please enter a past time:");

            do
            {
                input = Console.ReadLine();
                validTime = DateTime.TryParse(input, out time);


                if (validTime != true)
                {
                    Console.WriteLine($"'{input}' is in a invalid format.");
                    Console.WriteLine("Please try again:");
                }
                else if (time.CompareTo(DateTime.Now) >= 0)
                {
                    validTime = false;

                    Console.WriteLine($"'{input}' is in the future.");
                    Console.WriteLine("Please try again:");
                }

            } while (validTime != true);

            timeSpan = DateTime.Now.Subtract(time);

            Console.WriteLine($"{input} was {timeSpan.Hours} hours and {timeSpan.Minutes} minutes ago.");
        }
    }
}
