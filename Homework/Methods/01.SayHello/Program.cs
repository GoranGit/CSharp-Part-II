using System;
namespace _01.SayHello
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            sayHello(name);
        }
        static void sayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
