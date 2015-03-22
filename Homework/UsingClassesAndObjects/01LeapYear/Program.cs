using System;
namespace _01LeapYear
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());
           Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
