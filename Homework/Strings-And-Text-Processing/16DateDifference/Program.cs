using System;
using System.Threading;
namespace _16DateDifference
{
    class Program
    {
        static void Main()
        {
       
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy",null);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", null);
            Console.WriteLine("Distance:"+secondDate.Subtract(firstDate).Days+"days");
        }
    }
}
