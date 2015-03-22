using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add a sequence of integers separate by space :");
            string s = Console.ReadLine();
          int k= s.Split(' ').Sum(x=>int.Parse(x));
          Console.WriteLine(k);
              

        }
    }
}
