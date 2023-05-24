using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GOAL
// Create and use both an out variable in a method and
// a tuple. They do not have to be in the same method.
//
// BONUS
// Create a variable in one method, pass it into another
// method, modify it in the method, and without
// returning it, use the updated value in the initial
// method. Use two different techniques to make this
// work.

namespace ParameterChallenge001
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutMethod(out int outNumber);
            //Console.WriteLine(outNumber);

            //Console.WriteLine();

            //int tupleNumber1;
            //int tupleNumber2;

            //(tupleNumber1, tupleNumber2) = TupleMethod();

            //Console.WriteLine(tupleNumber1);
            //Console.WriteLine(tupleNumber2);

            InitialMethod2();

            Console.ReadLine();
        }

        static void OutMethod(out int number)
        {
            number = 10;
        }

        static (int x, int y) TupleMethod()
        {
            int x = 10;
            int y = 5;

            return (x, y);
        }

        static void InitialMethod1()
        {
            int variable = 16;

            OtherMethod1(out variable);

            Console.WriteLine(variable);
        }

        static void OtherMethod1(out int number)
        {
            number = 7;
        }

        static void InitialMethod2()
        {
            int variable = 16;

            OtherMethod2(ref variable);

            Console.WriteLine(variable);
        }

        static void OtherMethod2(ref int number)
        {
            number = number / 4;
        }
    }
}
