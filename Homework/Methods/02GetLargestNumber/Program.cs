using System;

namespace _02GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int subMax = GetMax(a, b);
            int max = GetMax(subMax, c);
            Console.WriteLine(max);
        }
        static int GetMax(int one,int two)
        {
            if (one > two)
                return one;
            else
                return two;


        }
    }
}
