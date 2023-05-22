﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class Extensions
    {
        public static void Print(this string message)
        {
            Console.WriteLine(message);
        }

        public static string Excite(this string message)
        {
            string output = message.Replace('.', '!');

            return output;
        }

        public static PersonModel Fill(this PersonModel person)
        {
            PersonModel output = person;

            Console.WriteLine("First Name:");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            output.LastName = Console.ReadLine();

            Console.WriteLine();

            return output;
        }

        public static void Print (this PersonModel person)
        {
            Console.WriteLine($"First Name: { person.FirstName }");
            Console.WriteLine($"Last Name: { person.LastName }");
            Console.WriteLine();
        }

        public static double Add(this double number, double numberToAdd)
        {
            number = number + numberToAdd;

            return number;
        }

        public static double Subract(this double number, double numberToSubtract)
        {
            number = number - numberToSubtract;

            return number;
        }

        public static double MultiplyBy(this double number, double numberToMultiplyBy)
        {
            number = number * numberToMultiplyBy;

            return number;
        }

        public static double DivideBy(this double number, double numberToDivideBy)
        {
            number = number / numberToDivideBy;

            return number;
        }
    }
}