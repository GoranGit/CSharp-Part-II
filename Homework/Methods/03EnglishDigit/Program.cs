using System;
namespace _03EnglishDigit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Word(n));
        }
        static string Word(int a)
        {
            int b = int.Parse(a.ToString()[a.ToString().Length - 1].ToString());
            switch(b)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";

            }
            return "No number";

        }

    }
}
