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
                TransactionModel result = null;

                try
                {
                    result = paymentProcessor.MakePayment($"Demo{i}", i);

                    if (result != null)
                    {
                        Console.WriteLine(result.TransactionAmount);
                    }
                    else
                    {
                        Console.WriteLine($"Null value for item { i }");
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Skipped invalid record { ex.InnerException?.Message }");
                }
                catch (FormatException ex) when (i != 5)
                {
                    Console.WriteLine($"Formatting Issue { ex.InnerException?.Message }");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Payment skipped for payment with { i } items { ex.InnerException?.Message }");
                }
            }
            Console.ReadLine();
        }
    }
}
