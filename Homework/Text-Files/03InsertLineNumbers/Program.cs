using System;
using System.IO;
namespace _03InsertLineNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input file name: ");
            string TextLocation = Console.ReadLine();
            StreamReader ReadText = new StreamReader(TextLocation);
            StreamWriter WriteNewText = new StreamWriter("newfile.txt");
            using (WriteNewText)
            {
                using (ReadText)
                {
                    int counter = 1;
                    string line = "";
                    while (line != null)
                    {
                        line = ReadText.ReadLine();
                        WriteNewText.WriteLine("{0}. - {1}", counter, line);
                        counter++;
                    }
                }
            }
        }
    }
}
