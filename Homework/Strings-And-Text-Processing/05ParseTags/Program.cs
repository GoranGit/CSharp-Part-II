using System;
using System.Text.RegularExpressions;
namespace _05ParseTags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var res = Regex.Replace(text, @"<upcase>(.*?)</upcase>",
                m =>
                {
                    string p = m.Groups[1].Value;
                    p =p.ToUpper();
                    return p;
                }


                );
            Console.WriteLine(res);
        }
    }
}
