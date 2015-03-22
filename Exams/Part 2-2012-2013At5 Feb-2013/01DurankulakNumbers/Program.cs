using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01DurankulakNumbers
{
    class Program
    {
        static void Main()
        {

            List<string> numSys = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                numSys.Add(((char)(65 + i)).ToString());

            }

            int stopToL = 77;// L=76 +1

            int stop = 91;
            for (int j = 97; j < 103; j++)
            {
                if (j == 102)
                    stop = stopToL;

                for (int i = 65; i < stop; i++)
                {


                    numSys.Add(( new string(new char[] { (char)j, (char)i })));
                }

            }


           
            string input = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            int k = 0;
            BigInteger result = new BigInteger();
            for(int i = input.Length-1;i>=0;i--)
            {

                word.Insert(0, input[i]);
                i--;
                while(i>=0 && Char.IsLower(input[i]))
                {
                    word.Insert(0, input[i]);
                    i--;
                }
                i++;

                if(numSys.Contains(word.ToString()))
                {
                    result = result + numSys.IndexOf(word.ToString()) * (BigInteger)Math.Pow(168, k);
                    k++;
                    word.Clear();
                }

            }

            Console.WriteLine(result);

        }
    }
}
