using System;
namespace _02RandomNumbers
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
			{
			 Console.WriteLine(r.Next(100,201));
			}
        }
    }
}
