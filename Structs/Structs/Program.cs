using System;

namespace Structs
{
    // Can not be specified as virtual, protected and abstract, only public and private
    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        // Structs can not have default constructors but defined constructors.
        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is: {0}", name);
            Console.WriteLine("Game 1's develope is: {0}", developer);
            Console.WriteLine("Game 1's rating is: {0}", rating);
            Console.WriteLine("Game 1's release date is: {0}", releaseDate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            // ERROR, have to define values first as is a struct
            //game1.Display();

            game1.name = "DOOM";
            game1.developer = "Bethesda";
            game1.rating = 10;
            game1.releaseDate = "20.04.2020";

            // Works by value, not by reference
            game1.Display();

            Console.ReadKey();
        }
    }
}
