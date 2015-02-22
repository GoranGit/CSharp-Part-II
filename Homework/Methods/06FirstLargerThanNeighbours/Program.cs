using System;
namespace _06FirstLargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add size of n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Add array:");
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(array));
        }
        static int Check(int[]array)
        {
            for(int i=1;i<array.Length-1;i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    return i;
            }
            return -1;

        }
    }
}
