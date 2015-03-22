using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02GreedyDwarf
{
    class Program
    {
        static void Main()
        {
            int[] valley = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray<int>();
            int m = int.Parse(Console.ReadLine());
         

            BigInteger maxMoney = new BigInteger();

            BigInteger moneySum = new BigInteger();
            int indexInValley = 0;
            bool firstSum = true;
            List<int>visited = new List<int>();
            bool firsCycle = true;

            List<int[]> patterns = new List<int[]>();
            for (int i = 0; i < m;i++ )
            {
                int[] pattern = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray<int>();
                patterns.Add(pattern);
            }

                for (int i = 0; i < m; i++)
                {

                    int[] pattern = patterns[i];
                    firsCycle = true;

                    indexInValley = 0;
                    moneySum = 0;

                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (j == 0 && firsCycle)
                        {
                            firsCycle = false;
                            indexInValley = 0;
                        }



                        if (!inValley(valley, indexInValley))
                            break;

                        if (visited.Contains(indexInValley))
                            break;

                        moneySum += valley[indexInValley];

                        visited.Add(indexInValley);

                        indexInValley = indexInValley + pattern[j];


                        if (j == pattern.Length - 1)
                        {
                            j = -1;
                        }

                    }

                    if (firstSum)
                    {
                        firstSum = false;
                        maxMoney = moneySum;
                    }

                    if (maxMoney < moneySum)
                    {
                        maxMoney = moneySum;
                    }

                    visited.Clear();

                }

            Console.WriteLine(maxMoney);

        }

        static bool inValley(int[] valley,int index)
        {
            if ((index >= valley.Length) || index < 0)
                return false;
            return true;

        }
    }
}
