using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }*/

            bool asking = true;
            Console.WriteLine("Press 1 whenever you wanna exit");

            Console.WriteLine("Ask something to the all-knowing console");
            Console.ReadLine();

            while (asking)
            {
                Random options = new Random();
                int num;
                num = options.Next(1, 4);

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Yes");
                        break;
                    case 2:
                        Console.WriteLine("No");
                        break;
                    case 3:
                        Console.WriteLine("Maybe");
                        break;
                }

                Console.WriteLine("\nAny other question?");
                Console.ReadLine();


            }


        }
    }
}
