using System;
using System.Collections.Generic;
namespace _14WordDictionary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write some  of '.NET','CLR','namespace':");
            string p = Console.ReadLine();
            Dictionary<string,string> k = new Dictionary<string,string>();

            k.Add(".NET", "platform for applications from Microsoft");
            k.Add("CLR", "managed execution environment for .NET");
            k.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine(k[p]);
        }
    }
}
