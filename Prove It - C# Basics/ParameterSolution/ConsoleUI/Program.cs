using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        // Out variable
        // Tuple
        // 2 different ways to modify data in a method and not pass it back yet use it.

        static void Main(string[] args)
        {
            //bool successfullyDivided = Divide(5, 3, out double result);

            //Console.WriteLine($"The result is { result }");

            //var mathResults = DoMath(5, 3);

            //Console.WriteLine($"Add: { mathResults.additionResult }, Subtract: { mathResults.subtractionResult }");

            //int age = 21;

            //ProcessNumber(ref age);

            //Console.WriteLine($"The new age is { age }");

            PersonModel user = new PersonModel();

            PopulateUser(user);

            Console.WriteLine($"User: { user.FirstName } { user.LastName }");

            Console.ReadLine();
        }

        private static bool Divide(double x, double y, out double result)
        {
            if(y == 0)
            {
                result = 0;
                return false;
            }

            result = x / y;

            return true;
        }

        private static (double additionResult, double subtractionResult) DoMath(double x, double y)
        {
            (double additionResult, double subtractionResult) output = (0, 0);

            output.additionResult = x + y;
            output.subtractionResult = x - y;

            return output;
        }

        private static void ProcessNumber(ref int value)
        {
            value *= 5;
        }

        private static void PopulateUser(PersonModel person)
        {
            person.FirstName = "Tim";
            person.LastName = "Corey";
        }
    }
}
