using System;
using System.IO;
using System.Text.RegularExpressions;
// result is in  Debug/result.txt
namespace _08ReplaceWholeWord
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the file path that you want to replace only whole words:");
            string input =   Console.ReadLine();
            StreamReader ReadFromFile = new StreamReader(input);
            StreamWriter WriteTheResults = new StreamWriter("result.txt");
            using (ReadFromFile)
            {
                using (WriteTheResults)
                {
                    string line = ReadFromFile.ReadLine();
                    while (line != null)
                    {
                        string NewLine = Regex.Replace(line, @"\bstart\b", " finish ");
                        WriteTheResults.WriteLine(NewLine);
                        line = ReadFromFile.ReadLine();
                    }
                }
            }
        }
    }
}
