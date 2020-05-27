using System;
using System.IO;

namespace ReadWriteIntoTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "Highscores:", "\n\t25", "\n\t30", "\n\t40" };
            // When writing if you enter an existing name of a txt file it will erase it's content and write the lines above
            // but if you put a non existent txt file name it will create it and write there.
            File.WriteAllLines(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\Testing.txt", lines);

            // Method 2
            /*Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\" + fileName +".txt",input);*/

            // Method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\TestingStreamWriter.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\TestingStreamWriter.txt", true))
            {
                file.WriteLine("Additional line");
            }



                /*
                // Example 1 - Reading whole text
                string text = System.IO.File.ReadAllText(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\Testing.txt");

                Console.WriteLine( "Textfile contains following text: {0}", text );

                // Example 2 - Reading Each line
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\user\Desktop\Cursos\C#\TextFiles\Testing.txt");

                Console.WriteLine("\nContents of the textfile is: ");
                foreach(string line in lines)
                {
                    Console.WriteLine("\t"+line);
                }*/

                Console.ReadKey();
        }
    }
}
