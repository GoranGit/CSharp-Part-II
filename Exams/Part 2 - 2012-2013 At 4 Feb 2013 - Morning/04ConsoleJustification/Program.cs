using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ConsoleJustification
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int lineSize = int.Parse(Console.ReadLine());
        
            List<string[]> words  = new List<string[]>();

            StringBuilder result = new StringBuilder();
            StringBuilder subResult = new StringBuilder();
            List<StringBuilder> line = new List<StringBuilder>();

            StringBuilder word = new StringBuilder();
            int lengthWord = 0;
            for(int i=0;i<lines;i++)
            {
                words.Add(Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries));
            }

            int wordsInLine = 0;

            for(int i=0;i<words.Count;i++)
            {
                for(int j =0;j<words[i].Length;j++)
                {
                    if (wordsInLine == 0)
                    {
                        lengthWord = words[i][j].Length;
                        wordsInLine++;
                        line.Add(new StringBuilder( words[i][j]));
                       

                    }
                    else
                    {
                        lengthWord += 1 + words[i][j].Length;
                        if (lengthWord <= lineSize)
                        {
                            line.Add(new StringBuilder(" "));
                                line.Add( new StringBuilder( words[i][j]));
                            wordsInLine++;
                        }
                        else
                        {
                            int spacesMiss = lineSize - (lengthWord - 1 - words[i][j].Length);
                            int spacesForEach =0;
                            int spacesForRest = 0;
                            if (wordsInLine - 1 == 0)
                                spacesForEach = 0;
                            else
                            spacesForEach = spacesMiss / (wordsInLine - 1);

                            if (wordsInLine - 1 == 0)
                                spacesForRest = 0;
                            else
                             spacesForRest= spacesMiss % (wordsInLine - 1);

                            for(int p = 1;p<line.Count;p+=2)
                            {
                                if(spacesForRest!=0)
                                {
                                    line[p].Append(" ");
                                    spacesForRest--;
                                }
                                line[p].Append(new string(' ',spacesForEach));
                               
                            }
                            foreach(StringBuilder l in line)
                            result.Append(l);
                            result.Append("\n");
                            line.Clear();
                            wordsInLine = 0;
                            lengthWord = 0;
                            j--;

                        }
                    }
                  

                }
            }
            if (line.Count != 0)
            {
                foreach (StringBuilder l in line)
                    result.Append(l);
            }
                 
            Console.Write(result.ToString());

        }
    }
}
