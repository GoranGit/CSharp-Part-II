using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                int k = int.Parse(Console.ReadLine());
               double sqrt = Math.Sqrt(k);
                if (k <0)
                    throw new ArgumentOutOfRangeException();
                Console.WriteLine(sqrt);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!" + e.Message);

            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

        }
    }
}
