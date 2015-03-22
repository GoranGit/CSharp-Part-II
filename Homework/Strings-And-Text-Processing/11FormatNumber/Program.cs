using System;

namespace _11FormatNumber
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
           Console.WriteLine("{0,15}",k);
           Console.WriteLine(String.Format("{0,15:X}", k));
            Console.WriteLine("{0,15:p}", (float)k/100);

        }
    }
}
