using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02EvenDifferences
{
    class Program
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray<long>();

            BigInteger resultSum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                long k = 0;

                if (numbers[i] > numbers[i - 1])
                    k = numbers[i] - numbers[i - 1];
                else
                    k = numbers[i - 1] - numbers[i];

             
              
                if (k % 2 == 0)
                {
                    resultSum += (BigInteger)k;
                    i++;
                }


            }

            Console.WriteLine(resultSum);

        }
    }
}
