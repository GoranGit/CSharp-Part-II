using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02JoroTheRabbit
{
    class Program
    {
        static void Main()
        {
            int[] numArray = Console.ReadLine().Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray<int>();

            int firstNum = 0;
            int steps = 0;
            int length = 0;
            int maxLen = 0;

            for(int i=0;i<numArray.Length;i++)
            {
                steps = numArray.Length-1;
                firstNum = i;

               for(int j = 1;j<=steps;j++)
               {
                   int p = i;
                   int k = i;
                    
                   if ((k + j) > (numArray.Length - 1))
                       k = ((k + j) % (numArray.Length))-j;

                   while(numArray[k+j]>numArray[p])
                   {
                       length++;
                       k += j;
                       p = k;
                       if (k+j > numArray.Length - 1)
                           k =(( (k+j) % (numArray.Length)) - j);


                   }
                   if (length > maxLen)
                       maxLen = length;

                   length = 0;
               }
            }

            Console.WriteLine(maxLen+1);

        }
    }
}
