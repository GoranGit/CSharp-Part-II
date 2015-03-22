using System;
using System.Globalization;
using System.Text;
using System.Threading;
namespace _17DateInBulgarian
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            Console.OutputEncoding = Encoding.UTF8;
       
           // dd.MM.yyyy hh:mm:ss

            // first set Console font to Lucida Console and Size = 12

            Console.WriteLine("dd.MM.yyyy hh:mm:ss");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            if ((date.Hour == 6 && date.Minute >= 30) || date.Hour > 6)
            {
                Console.WriteLine(date.ToString("d.MM.yyyy hh:mm:ss dddd", new CultureInfo("bg-BG")));


            }
            else
                Console.WriteLine(date.ToString("d.MM.yyyy hh:mm:ss", new CultureInfo("bg-BG")));
        }
    }
}
