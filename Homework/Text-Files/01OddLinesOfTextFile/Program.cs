using System;
using System.IO;

namespace _01OddLinesOfTextFile
{
    class Program
    {
        static void Main()
        {


            Console.Write("File path: ");
            string file = Console.ReadLine();
            try
            {             
                    string[] lines = System.IO.File.ReadAllLines(file);
                   for(int i=0;i<lines.Length;i+=2)
                   {
                       Console.WriteLine(lines[i]);
                   }
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
