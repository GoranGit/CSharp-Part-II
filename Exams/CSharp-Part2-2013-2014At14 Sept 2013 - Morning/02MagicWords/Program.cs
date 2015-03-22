using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MagicWords
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            List<string> words = new List<string>();
           
            for(int i=0;i<n;i++)
            {
                words.Add(Console.ReadLine());

            }

            int index = 0;
            string word ;
            for(int i=0;i<n;i++)
            {
                word = words[i];
               index =  words[i].Length % (n + 1);
               words[i] = null;
               words.Insert(index, word);
               words.Remove(null);

            }

            


            Print(words);



        }
        static void Print( List<string> k)
        {
            bool hasLetters = true;
            int letterIndex = 0;
            StringBuilder result = new StringBuilder();
            while(hasLetters)
            {
                hasLetters = false;

                for(int i=0;i<k.Count;i++)
                {
                if(k[i]!="" && k[i].Length-1>=letterIndex)
                {


                    result.Append(k[i][letterIndex]);

                        hasLetters = true;
                }
              


                }

                letterIndex++;
            }

            Console.WriteLine(result);

        }
    }
}
