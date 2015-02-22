using System;
using System.Linq;
//write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
namespace _02MaximalSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
           decimal[,]matrix = new decimal[n,m];

            for(int i = 0;i<n;i++)
                for(int j=0;j<m;j++)
                {
                    matrix[i,j] = decimal.Parse(Console.ReadLine());
                }


            decimal sum = 0;
            decimal[,] sumMatrix = new decimal[3,3];
            decimal maxSum = decimal.MinValue;
            decimal[,] maxMatri = new decimal[3, 3];


            for(int i=0;i<=n - 3;i++)
            {
                for(int j=0;j<=m-3;j++)
                {
                    sum = (sumMatrix[0,0]= matrix[i, j]) + (sumMatrix[0,1]= matrix[i, j + 1]) +(sumMatrix[0,2]= matrix[i, j + 2]) +
                           (sumMatrix[1,0]= matrix[i + 1, j]) +(sumMatrix[1,1]= matrix[i + 1, j + 1]) +(sumMatrix[1,2]= matrix[i + 1, j + 2]) +
                            (sumMatrix[2,0]= matrix[i + 2, j]) +(sumMatrix[2,1]= matrix[i + 2, j + 1]) +(sumMatrix[2,2]= matrix[i + 2, j + 2]);

                    if (sum > maxSum)
                    {  for(int p =0;p<3;p++)
                        for (int q = 0; q < 3; q++)
                        {
                            maxMatri[p, q] = sumMatrix[p, q];
                        }
                    maxSum = sum;
                    }
                }
                
            }

            Console.WriteLine(maxSum);
            for (int p = 0; p < 3; p++)
            {
                for (int q = 0; q < 3; q++)
                {
                    Console.Write(maxMatri[p, q]+" ");
                }
                Console.WriteLine();

            }
        }
    }
}
