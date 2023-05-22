using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge001
{
    public static class Bonus
    {
        public static void DateSequence()
        {
            string input = "";
            bool validFormatSelected = false;
            string dateFormat = "";
            bool validDate = false;
            DateTime date = new DateTime();
            int daysAgo = 0;
            string dayOrDays = "";

            Console.WriteLine("Please select your preferred Date format:");
            Console.WriteLine("A) month/day/year");
            Console.WriteLine("B) day/month/year");

            do
            {
                input = Console.ReadLine();

                if (input.ToLower().Trim() == "a")
                {
                    validFormatSelected = true;
                    dateFormat = "M/d/yyyy";
                }
                else if (input.ToLower().Trim() == "b")
                {
                    validFormatSelected = true;
                    dateFormat = "d/M/yyyy";
                }
                else
                {
                    Console.WriteLine($"'{input}' is invalid. Please enter either 'a' or 'b'.");
                }

            } while (validFormatSelected != true);

            Console.WriteLine();
            Console.WriteLine("Please enter a past date:");

            do
            {
                input = Console.ReadLine();

                validDate = DateTime.TryParseExact(
                    input,
                    dateFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out date);

                if (validDate != true)
                {
                    Console.WriteLine($"'{input}' is in a invalid format.");
                    Console.WriteLine($"Please try entering a date in the format '{dateFormat}' again:");
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
            bool validFormatSelected = false;
            string timeFormat = "";

            Console.WriteLine("Please select your preferred Time format:");
            Console.WriteLine("A) 12 Hours");
            Console.WriteLine("B) 24 Hours");

            do
            {
                input = Console.ReadLine();

                if (input.ToLower().Trim() == "a")
                {
                    validFormatSelected = true;
                    timeFormat = "hh:mm tt";
                }
                else if (input.ToLower().Trim() == "b")
                {
                    validFormatSelected = true;
                    timeFormat = "HH:mm";
                }
                else
                {
                    Console.WriteLine($"'{input}' is invalid. Please enter either 'a' or 'b'.");
                }

            } while (validFormatSelected != true);

            Console.WriteLine();
            Console.WriteLine("Please enter a past time:");

            do
            {
                input = Console.ReadLine();

                validTime = DateTime.TryParseExact(
                    input,
                    timeFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out time);

                if (validTime != true)
                {
                    Console.WriteLine($"'{input}' is in a invalid format.");
                    Console.WriteLine($"Please try entering a time in the format '{timeFormat}' again:");
                }

            } while (validTime != true);

            timeSpan = DateTime.Now.Subtract(time);

            Console.WriteLine($"{input} was {timeSpan.Hours} hours and {timeSpan.Minutes} minutes ago.");
        }
    }
}
