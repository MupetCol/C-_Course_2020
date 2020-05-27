using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower num of {0} and {1} is {2}", num1,num2,Math.Min(num1,num2));
            Console.WriteLine("Higuer num of {0} and {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of five is {0}", Math.Pow(3,5));
            Console.WriteLine("PI is: {0}", Math.PI);

            Console.WriteLine("The square root of 25 is {0}",Math.Sqrt(25));
            Console.WriteLine("Always positive {0}",Math.Abs(-999));
            Console.WriteLine("cos of 1 is {0}", Math.Cos(1));



        }
    }
}
