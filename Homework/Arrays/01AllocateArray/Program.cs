using System;

namespace _01AllocateArray
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[20];
            for(int i=0;i<20;i++)
            {
                a[i] = i * 5;
                Console.WriteLine(a[i]);
            }
        }
    }
}
