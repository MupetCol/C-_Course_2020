using System;

namespace Enums
{
    // Set of constances, immutable, placed at the namespace level can be used by the whole library
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
    // We can reasign index, and it will keep counting from that number
    enum Month { Jan = 1, Feb, March, April, May, June = 12, July, Aug, Sept, Oct, Nov, Dec };

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day mo = Day.Mo;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Feb);

            Console.ReadKey();
        }
    }
}
