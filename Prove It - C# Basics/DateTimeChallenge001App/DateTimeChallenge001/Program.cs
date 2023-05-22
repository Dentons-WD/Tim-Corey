using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge001
{
    class Program
    {
        static void Main(string[] args)
        {
            // GOAL
            // Capture a date from the console and calculate how
            // many days ago it was. Then capture a time from the
            // console and calculate how many hours and minutes
            // ago it was (assume less than now and not previous
            // day).
            //Goal.DateSequence();
            //Console.WriteLine();
            //Goal.TimeSequence();

            // BONUS
            // For times, allow the user to choose to specify 12-or 24-
            // hourformat. For dates, allow the user to specify
            // month/day/year or day/month/year format based
            // upon their choice. Also, don’t assume times are not
            // the previous day.
            Bonus.DateSequence();
            Bonus.TimeSequence();

            Console.ReadLine();
        }
    }
}
