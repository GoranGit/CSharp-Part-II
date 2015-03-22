using System;
using System.IO;

namespace _04CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first file: ");
            string file1 = Console.ReadLine();
            Console.Write("Input second file: ");
            string file2 = Console.ReadLine();
            StreamReader FileReader1 = new StreamReader(file1);
            StreamReader FileReader2 = new StreamReader(file2);
            int SameCounter = 0;
            int DifferentCounter = 0;
            using (FileReader1)
            {
                using (FileReader2)
                {
                    string line1 = FileReader1.ReadLine();
                    string line2 = FileReader2.ReadLine();
                    while (line1 != null && line2 != null)
                    {
                        if (line1.Equals(line2))
                        {
                            SameCounter++;
                        }
                        else
                        {
                            DifferentCounter++;
                        }
                        line1 = FileReader1.ReadLine();
                        line2 = FileReader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("Number of lines that are the same is: {0}", SameCounter);
            Console.WriteLine("Number of lines that are different is: {0}", DifferentCounter);
            StreamWriter ResultOutput = new StreamWriter("result.txt");
            using (ResultOutput)
            {
                ResultOutput.WriteLine("Number of lines that are the same is: {0}", SameCounter);
                ResultOutput.WriteLine("Number of lines that are different is: {0}", DifferentCounter);
            }
        }
    }
}
