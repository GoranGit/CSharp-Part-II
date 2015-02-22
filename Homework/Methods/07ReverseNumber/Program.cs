using System;
using System.Linq;
namespace _07ReverseNumber
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Revers(k));
        }
        static int Revers(int a)
        {
            char[] p = a.ToString().ToCharArray();
            Array.Reverse(p);
            string l = new string(p);

            return int.Parse(l);
        }
    }
}
