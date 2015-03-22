using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DecodeAndDecrypt
{
    class Program
    {
        static void Main()
        {

            string input  = Console.ReadLine();
            int p = input.Length-1;
            StringBuilder r = new StringBuilder();
            while(char.IsDigit(input[p]))
            {
                r.Append(input[p]);
                p--;
            }


            int lenCy = r.Length;

            string rS = r.ToString();

            char[] rSV = rS.Reverse().ToArray();
            rS = new string(rSV);

            int cyLen = int.Parse(rS);


            string unCompressed = GetBackAllLetters(input,lenCy).ToString();
            //Console.WriteLine(unCompressed);

            string cypher = unCompressed.Substring(unCompressed.Length - cyLen, cyLen);


           // Console.WriteLine(cypher);

            string coded = unCompressed.Substring(0, unCompressed.Length - cypher.Length);
            Console.WriteLine(Decode(coded, cypher));


        }
        
        static StringBuilder  GetBackAllLetters(string input,int lenCy)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder subR = new StringBuilder();
           for(int i=0;i<input.Length-lenCy;i++)
           {
               if (char.IsDigit(input[i]))
               {
                   StringBuilder u = new StringBuilder();
                   while(char.IsDigit(input[i]))
                   {
                       u.Append(input[i]);
                       i++;
                   }

                   int k = int.Parse(u.ToString());
                   u.Clear();

                   subR.Append(new string(input[i], k));
                  
                  
                   result.Append(subR);
                   subR.Clear();

               }
               else
                   result.Append(input[i]);
           }
           return result;

        }

        static StringBuilder Decode(string coded,string cypher)
        {
            StringBuilder result = new StringBuilder();
            string bigger = coded.Length > cypher.Length ? coded : cypher;
            if(coded.Length>cypher.Length || coded.Length==cypher.Length)
            {
               
                for(int i=0;i<coded.Length;i++)
                {
                    result.Append((char)((((int)coded[i] -65) ^ ((int)cypher[i % cypher.Length]-65))+65));

                }

            }else
               
                {
                    StringBuilder subRez = new StringBuilder(coded);

                    for (int i = 0; i < cypher.Length; i++)
                    {

                        int posInsert = i % subRez.Length;
                        subRez.Insert(i % subRez.Length, ((char)((((int)subRez[i % subRez.Length] - 65) ^ ((int)cypher[i] - 65)) + 65)));

                        subRez.Remove(posInsert+1, 1);
                        
                    }
                   return subRez;
                }
            return result;
        }

    }
}
