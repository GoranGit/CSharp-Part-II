using System;
using System.IO;

namespace _02TwoFilesConcat
{
    class Program
    {
        static void Main()
        {

            Console.Write("Input first file name: ");
            string file1Name = Console.ReadLine();
            Console.Write("Input second file name: ");
            string file2Name = Console.ReadLine();
            string newFileName = "NewFile.txt";
            StreamWriter ConcatFiles = new StreamWriter(newFileName);
            using (ConcatFiles)
            {
                using (StreamReader TextFile = new StreamReader(file1Name))
                {
                    string line = "";
                   
                        line = TextFile.ReadToEnd();
                        ConcatFiles.WriteLine(line);
                    
                }
                using (StreamReader TextFile = new StreamReader(file2Name))
                {
                    string line = "";
                  
                        line = TextFile.ReadToEnd();
                        ConcatFiles.WriteLine(line);
                    
                }
            }


        }
    }
}
