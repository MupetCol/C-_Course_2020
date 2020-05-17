using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 1, 2, 5, 3, 4, 3 };
            double averageResult = GetAverage(studentGrades);

            int[] happiness = new int[] { 2, 5, 6, 1, 7 };

            Console.WriteLine("Starting happiness values");
            foreach (int happy in happiness)
            {
                //Console.WriteLine("{0}",grade);
                Console.WriteLine(happy);
            }
            GiveMoney(happiness);
            Console.WriteLine("Final happiness values");
            foreach (int happy in happiness)
            {
                //Console.WriteLine("{0}",grade);
                Console.WriteLine(happy);
            }

            //Console.WriteLine("The average is: {0}",averageResult);
            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void GiveMoney(int[] happiness)
        {
            
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }

        }
    }
}
