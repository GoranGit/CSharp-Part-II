using System;
using System.Text.RegularExpressions;
namespace _18ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string p = Console.ReadLine();

            var reg = Regex.Matches(p, @"\w+@\w+\.\w+");
          
            foreach (var item in reg)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
