using System;
namespace _08BinaryShort
{
    class Program
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16,'0'));
        }
    }
}
