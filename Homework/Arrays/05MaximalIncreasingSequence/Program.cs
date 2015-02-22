using System;
using System.Linq;
namespace _05MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = a.Select((s,b)=> new {s*3,b*b}).ToArray();
            foreach (int k in b)
                Console.WriteLine(k);

        }
    }
}
