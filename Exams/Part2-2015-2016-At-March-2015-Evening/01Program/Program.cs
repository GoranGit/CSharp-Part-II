using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01Program
{
    class Program
    {
        static void Main()
        {
            List<char> numSys = new List<char>();
            for(int i=97;i<=119;i++)
            {
                numSys.Add((char)i);
            }

            string[] input = Console.ReadLine().Split(' ');


            BigInteger wordNumberInDec = 0;
            BigInteger sumDecimal = 0;

            for(int i=0;i<input.Length;i++)
            {
                char[] number = input[i].ToCharArray();
                Array.Reverse(number);
                for(int j=0;j<number.Length;j++)
                {
                    wordNumberInDec += numSys.IndexOf(number[j]) * (BigInteger)Math.Pow(23, j);
                }
                sumDecimal += wordNumberInDec;
                wordNumberInDec = 0;
            }

         

            BigInteger p = sumDecimal;
            StringBuilder resultIn23 = new StringBuilder();

            List<int> array = new List<int>();

            while(p!=0)
            {
                array.Add((int)(p % 23));
                p /= 23;

            }

            array.Reverse();

            for(int i=0;i<array.Count;i++)
            {
            resultIn23.Append(numSys[array[i]]);
            }

            Console.WriteLine("{0} = {1}", resultIn23, sumDecimal);


        }
    }
}
