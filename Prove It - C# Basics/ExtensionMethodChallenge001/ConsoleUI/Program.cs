 ﻿using System;
using System.Security.Claims;

// GOAL
// Create two extension methods. One called Print that
// prints a string to the console like so:
// “HelloWorld”.Print() and one called Excite that
// replaces all periods with exclamation points like so:
// “Hello World.”.Excite()

// BONUS
// Create this chain for a Person object:
// <person>.Fill().Print(); where Fill asks the user for each
// property’s value and print will print all properties to
// the console. Then create this chain on a double:
// <double>.Add(4).Subtract(2).MultiplyBy(8).DivideBy(3);

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Hello World.".Excite().Print();

            //PersonModel person = new PersonModel();
            //person.Fill().Print();

            double x = 3;
            x = x.Add(5).Subract(2).MultiplyBy(8).DivideBy(3);

            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}