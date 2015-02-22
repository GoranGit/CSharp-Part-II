using System;
using System.Collections.Generic;

namespace _08NumberAsArray
{
    class Program
    {
        static void Main()
        {

            Console.Write("n elementa of array a:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]", i);
                a[i] = int.Parse(Console.ReadLine());
            }



                Console.Write(" m  elements of array b:");
            int m = int.Parse(Console.ReadLine());
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write("b[{0}]", i);
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            List<int> k = AddDigits(a, b);
            foreach (var l in k)
                Console.Write(l);

        }

        static List<int> AddDigits(int[] a,int[] b)
        {
            int reminder = 0;
            List<int> result = new List<int>();
            int n = a.Length>b.Length?b.Length:a.Length;
            int rest = a.Length > b.Length ? a.Length : b.Length;
            int[] referToBigger = a.Length > b.Length ? a : b;

          
            int subSum = 0;
            int i = 0;
            for( i=0;i<n;i++)
            {
                
                subSum = (a[i]+b[i]+reminder)%10;
                result.Add(subSum);
                reminder = (a[i] + b[i] + reminder) / 10;
            }

            for (; i < rest; i++)
            {
                result.Add((referToBigger[i] + reminder)%10);

                reminder = (referToBigger[i] + reminder) / 10;
            }
            if (reminder == 1)
                result.Add(1);

            result.Reverse();

                return result;

        }
    }
}
