using System;
using System.Linq;
namespace _09SortingArray
{
    class Program
    {
        static void Main()
        {

            Console.Write("Add  size of  array n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("a[{0}]", i);
              array[i]= int.Parse(Console.ReadLine());
            }

            Console.Write("Ascending? (if yes enter 'true' if no enter 'false')");

            bool ascending = bool.Parse(Console.ReadLine());
            int[] sorted =new int[n];
            sorted = Sort(array, ascending);

            foreach (int k in sorted)
                Console.WriteLine(k);

        }

        static int FindMax(int[]array , int fromIndex)
        {
            int max = array[fromIndex];
            for(int i=fromIndex+1;i<array.Length;i++)
            {
                if(array[i]>max)
                    max = array[i];
            }
            return max;

        }

        static int[] Sort(int[]array,bool ascending)
        {
            int[] result = new int[array.Length];
            int index = 0;
            int max = 0;
                for(int i=0;i<array.Length;i++)
                {
                    max = FindMax(array, i);
                    result[i] = max;

                  index=  Array.IndexOf(array, max);

                  int pom = array[index];
                  array[index] = array[i];
                  array[i] = pom;


                }

                if (ascending)
                {
                    Array.Reverse(result);
                    return result;
                }
                else
                    return result;
            
        }

    }
}
