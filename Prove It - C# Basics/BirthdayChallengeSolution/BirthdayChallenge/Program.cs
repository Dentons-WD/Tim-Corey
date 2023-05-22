using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1984, 11, 1);
            // March 11, 2019 - 7 years or 95 months or 2,879 days

            int years = HowManyYearsOld(birthday);
            Console.WriteLine($"You are {years} years old.");

            int months = HowManyMonthsOld(birthday);
            Console.WriteLine($"You are { months } months old.");
            
            int days = HowManyDaysOld(birthday);
            Console.WriteLine($"You are { days } days old.");

            int daysUntilBirthday = DaysUntilNextBirthday(birthday);
            Console.WriteLine($"There are { daysUntilBirthday } days until your birthday."); 

            int monthsUntilBirthday = MonthsUntilNextBirthday(birthday);
            Console.WriteLine($"There are { monthsUntilBirthday } months until your birthday."); 

            int numberOfWeekendsUntilBirthday = NumberOfWeekendsUntilNextBirthday(birthday);
            Console.WriteLine($"There are { numberOfWeekendsUntilBirthday } weekends until your birthday."); 

            Console.ReadLine();
        }

        private static int HowManyYearsOld(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            int years = now.Year - birthday.Year;

            if (now.Month < birthday.Month)
            {
                years -= 1;
            }
            else 
            {
                if (now.Month == birthday.Month && now.Day < birthday.Day)
                {
                    years -= 1;
                }
            }

            return years;
        }

        private static int HowManyMonthsOld(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            int years = HowManyYearsOld(birthday);
            int months = years * 12;

            if (now.Month < birthday.Month)
            {
                months += (now.Month + 12 - birthday.Month);
            }
            else
            {
                months += (now.Month - birthday.Month);
            }

            return months;
        }

        private static int HowManyDaysOld(DateTime birthday)
        {
            DateTime now = DateTime.Now;

            int days = now.Subtract(birthday).Days;

            return days;
        }

        private static int DaysUntilNextBirthday(DateTime birthday)
        {
            DateTime nextBirthday = GetNextBirthday(birthday);

            int days = nextBirthday.Subtract(DateTime.Now).Days;

            return days;
        }

        private static int MonthsUntilNextBirthday(DateTime birthday)
        {
            DateTime nextBirthday = GetNextBirthday(birthday);
            DateTime now = DateTime.Now;
            int months = 0;
            
            if (nextBirthday.Month < now.Month)
            {
                months += (nextBirthday.Month + 12 - now.Month);
            }
            else
            {
                months += (nextBirthday.Month - now.Month);
            }

            DateTime monthBeforeBirthday = new DateTime(nextBirthday.Year, nextBirthday.Month - 1, now.Day);

            int daysInLastMonth = nextBirthday.Subtract(monthBeforeBirthday).Days;

            if (daysInLastMonth <= 15)
            {
                months -= 1;
            }

            return months;
        }

        private static int NumberOfWeekendsUntilNextBirthday(DateTime birthday)
        {
            DateTime nextBirthday = GetNextBirthday(birthday);
            int totalDaysLeft = DaysUntilNextBirthday(birthday);
            int numberOfWeekends = totalDaysLeft / 7;
            int remainingDays = totalDaysLeft % 7;
            int daysUntilWeekend = 0;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    daysUntilWeekend = 0;
                    break;
                case DayOfWeek.Monday:
                    daysUntilWeekend = 5;
                    break;
                case DayOfWeek.Tuesday:
                    daysUntilWeekend = 4;
                    break;
                case DayOfWeek.Wednesday:
                    daysUntilWeekend = 3;
                    break;
                case DayOfWeek.Thursday:
                    daysUntilWeekend = 2;
                    break;
                case DayOfWeek.Friday:
                    daysUntilWeekend = 1;
                    break;
                case DayOfWeek.Saturday:
                    daysUntilWeekend = 0;
                    break;
                default:
                    break;
            }

            if (remainingDays >= daysUntilWeekend)
            {
                numberOfWeekends += 1;
            }

            return numberOfWeekends;
        }

        private static DateTime GetNextBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            int year = now.Year;

            if (now.Month > birthday.Month)
            {
                year += 1;
            }
            else
            {
                if (now.Month == birthday.Month && now.Day >= birthday.Day)
                {
                    year += 1;
                }
            }

            DateTime output = new DateTime(year, birthday.Month, birthday.Day);

            return output;
        }
    }
}
