using System;
using System.Collections.Generic;
using System.IO;
// result is in Debug folder
namespace _06SaveSortedNames
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a path to the input file: ");
           string input = Console.ReadLine();
            StreamReader ReadListOfStrings = new StreamReader(input);
            List<string> ListOfNames = new List<string>();
            using (ReadListOfStrings)
            {

                string Current = "";
                while (Current != null)
                {
                    Current = ReadListOfStrings.ReadLine();
                    ListOfNames.Add(Current);
                }

            }
            ListOfNames.Sort();
            StreamWriter WriteSortedNames = new StreamWriter("result.txt");
            using (WriteSortedNames)
            {
                for (int index = 1; index < ListOfNames.Count; index++)
                {
                    WriteSortedNames.WriteLine("{0}. {1}", index, ListOfNames[index]);
                }
            }
        }
    }
}
