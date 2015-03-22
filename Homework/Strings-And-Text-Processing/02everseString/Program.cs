using System;
//Write a program that reads a string, reverses it and prints the result at the console.
namespace _02everseString
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string which you want to reverse : ");
            string k = Console.ReadLine();
           char[] p= k.ToCharArray();
            Array.Reverse(p);
            Console.WriteLine(new string(p));
        }
    }
}
