using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Manera útil de como visualizar jagged arrays EXPLICACIÓN
             * 
             *      index                   0   1   2   3
             * normal array of type int : [15],[2],[3],[55]
             * 
             *      index                           0                        1                  2
             *jagged array of type int : [array1([15],[13],[4]),array2([55],[7],[90]),array3([9],[2],[7])]
             * 
             */ 




            //How to declare a jagged array and the number of arrays it contain, in this case 3
            int[][] jaggedArray = new int[3][];

            //First way to declare the arrays contained
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            //Second way which not only declares but also initializes them with their base values
            jaggedArray[0] = new int[] { 2, 77, 8, 9, 10, 6, 8 };
            jaggedArray[1] = new int[] { 1, 2, 3 , 4};
            jaggedArray[2] = new int[] { 12, 21, 33 };

            //Alternative way:

            int[][] jaggedArray2 = new int[][]
            {
                new int[]{2,3,4,6,7},
                new int[]{2,3,5,1,23,5}
            };

            //La manera ñoña en que yo lo hice NUNCA HACER ASÍ


            //Console.WriteLine("Last value of the first array is: {0}",jaggedArray2[0][4]);
            
            //Console.WriteLine("\n {0} {1} {2} {3} {4} \n {5} {6} {7} {8} {9} {10}",
            //    jaggedArray2[0][0], jaggedArray2[0][1], jaggedArray2[0][2],
            //    jaggedArray2[0][3], jaggedArray2[0][4], jaggedArray2[1][0],
            //    jaggedArray2[1][1], jaggedArray2[1][2], jaggedArray2[1][3],
            //    jaggedArray2[1][4], jaggedArray2[1][5]);


            //Manera pro y lógica
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}",i+1);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("Value number {0} is: {1}",j + 1,jaggedArray2[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
