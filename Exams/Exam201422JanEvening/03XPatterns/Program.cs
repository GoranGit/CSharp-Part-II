using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03XPatterns
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] rows;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                rows = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(rows[j]);
                }
            }

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            bool hasValid = false;
            bool firstSum = true;
            BigInteger sum = 0;



            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < n - 4; j++)
                {
                    a = matrix[i, j];
                    if (matrix[i, j + 1] == a + 1)
                    {
                        b = matrix[i, j + 1];
                        if (matrix[i, j + 2] == b + 1)
                        {
                            c = matrix[i, j + 2]; ;
                            if (matrix[i + 1, j + 2] == c + 1)
                            {
                                d = matrix[i + 1, j + 2];
                                if (matrix[i + 2, j + 2] == d + 1)
                                {
                                    e = matrix[i + 2, j + 2];
                                    if (matrix[i + 2, j + 3] == e + 1)
                                    {
                                        f = matrix[i + 2, j + 3];
                                        if (matrix[i + 2, j + 4] == f + 1)
                                        {
                                            g = matrix[i + 2, j + 4];
                                            hasValid = true;

                                            if ((sum < (a + b + c + d + e + f + g)) || firstSum)
                                            {
                                                firstSum = false;
                                                sum = (a + b + c + d + e + f + g);
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }



                }

            }


              if(hasValid)
                    Console.WriteLine("YES {0}",sum);
                    else
                    {   
                       for(int i=0;i<n;i++)
                        
                               sum+=matrix[i,i];
                        
                        
                        Console.WriteLine("NO {0}",sum);
                    }
        }

    }
}
