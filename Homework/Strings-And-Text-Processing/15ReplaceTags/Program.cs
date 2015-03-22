using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15ReplaceTags
{

    // example for test : <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var rez = Regex.Replace(text, @"<a href=""(.*?)"">(.*?)</a>",
                m =>
                {
                    string p = m.Value;
                   p = p.Replace(@"<a href=""", "[URL=").Replace("</a>", "[/URL]").Replace(@""">", "]");
                    return p;
                });

            Console.WriteLine(rez);

        }
    }
}
