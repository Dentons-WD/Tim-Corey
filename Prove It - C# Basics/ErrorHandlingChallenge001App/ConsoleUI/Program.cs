using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                // GOAL
                //try
                //{
                //    var result = paymentProcessor.MakePayment($"Demo{ i }", i);

                //    if (result == null)
                //    {
                //        Console.WriteLine($"Null value for item { i }");
                //    }
                //    else
                //    {
                //        Console.WriteLine(result.TransactionAmount);
                //    } 
                //}
                //catch (Exception ex)
                //{

                //    Console.WriteLine($"Payment skipped for payment with { i } items");
                //}

                // BONUS
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{ i }", i);

                    if (result == null)
                    {
                        Console.WriteLine($"Null value for item {i}");
                    }
                    else
                    {
                        Console.WriteLine(result.TransactionAmount);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is IndexOutOfRangeException)
                    {
                        Console.Write("Skipped invalid record.");
                    }
                    else if (ex is FormatException && i != 5)
                    {
                        Console.Write("Formatting Issue");
                    }
                    else
                    {
                        Console.Write($"Payment skipped for payment with { i } items.");
                    }

                    if (ex.InnerException != null)
                    {
                        Console.Write($" { ex.InnerException.Message }");
                    }

                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
