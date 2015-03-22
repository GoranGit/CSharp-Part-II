using System;
using System.IO;
using System.Text.RegularExpressions;
//Example for test:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>


// result is in Debug/result.txt

namespace _10ExtractTextFromXML
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input file path: ");
            string inputFile = Console.ReadLine();
            string contentFile = "result.txt";
            StreamReader ReadWebsite = new StreamReader(inputFile);
            StreamWriter ExtractContent = new StreamWriter(contentFile);
            string pattern = @">(.*?)\<";
            using (ReadWebsite)
            {
                using (ExtractContent)
                {
                    string line = ReadWebsite.ReadLine();
                    while (line != null)
                    {
                        Regex content = new Regex(pattern);
                        MatchCollection result = content.Matches(line);
                        foreach (var Line in result)
                        {
                            ExtractContent.WriteLine(Line);
                            Console.WriteLine(Line);       
                        }
                        line = ReadWebsite.ReadLine();
                    }
                }
            }
        }
    }
}
