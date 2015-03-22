using System;
using System.Collections.Generic;
using System.Text;

namespace _13ReverseSentence
{
    class Program
    {
        static void Main()
        {
            List<int> indexsOfComa = new List<int>();
            string input = Console.ReadLine();
            input = input.Trim();
            int wordCounter = 0;
            for (int i=0;i<input.Length;i++ )
            {
                if(input[i]==' ')
                    wordCounter++;

                if(input[i]==',')
                {   
                   
                    indexsOfComa.Add(wordCounter);
                 }
            }


            string[] words = input.Split(new char[] { ',', ' ' });
            Array.Reverse(words);
            StringBuilder resutl = new StringBuilder();
            char interpunction = words[0][words[0].Length - 1];
           words[0]= words[0].Remove(words[0].Length - 1);

            for(int i=0;i<words.Length;i++)
            {

                if (indexsOfComa.Contains(i))
                {
                    resutl.Append(words[i] + ", ");

                }
                else
                    resutl.Append(words[i] + " ");
            }

            string res = resutl.ToString().Trim();
            res += interpunction.ToString();

            Console.WriteLine(res);

        }
    }
}
