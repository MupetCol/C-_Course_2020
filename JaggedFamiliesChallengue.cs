using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedFamilies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] Families = new string[][]
            {
                new string[]{"Diana", "Carlos"},
                new string[]{"Marta", "Javier"},
                new string[]{"Andrea", "Adrian"}
            };

            //Unnecesarily complex
            /*
            Console.WriteLine("Let me introduce you to each other: ");
            for (int i = 0; i < Families.Length; i++)
            {
                for (int j = 0; j < Families[i].Length - 1; j++)
                {
                    if (i == 0)
                        Console.Write("\nThey are {0} and {1}", Families[i][j], Families[i][j + 1]);
                    else if (i == 1)
                        Console.Write(" they are {0} and {1}", Families[i][j], Families[i][j + 1]);
                    else if (i == 2)
                        Console.Write(" and lastly they are {0} and {1}", Families[i][j], Families[i][j + 1]);
                }
            }
            */
            //Introducing them to each other would be like
            Console.WriteLine("Hello {0} hi {1}, i'd like to introduce you guys to {2} and {3}", Families[0][0], Families[0][1], Families[1][0],Families[1][1]);
            Console.WriteLine("Hello {0} hi {1}, i'd like to introduce you guys to {2} and {3}", Families[0][0], Families[0][1], Families[2][0], Families[2][1]);
            Console.WriteLine("Hello {0} hi {1}, i'd like to introduce you guys to {2} and {3}", Families[1][0], Families[1][1], Families[2][0], Families[2][1]);
            Console.ReadKey();
        }
    }
}
