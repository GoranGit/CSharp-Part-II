using System;
namespace _05LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add size of n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add index i:");
            int index = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(Check(array, index));

        }
        static bool Check(int[] array,int position)
        {
            if (position - 1 < 0 || position + 1 > array.Length - 1)
                return false;

            if (array[position] > array[position + 1] && array[position] > array[position - 1])
                return true;
            else
                return false;
        }
    }
}
