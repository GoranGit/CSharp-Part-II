using System;
using System.Text;
namespace _08ExtractSentences
{
    class Program
    {
        static void Main()
        {
            //exam to test:  We are living in a yellow submarine. We don't have anything else. In
            //. So we are drinking all the day. We will move out of it in 5 days.

            Console.WriteLine("Enter a text that you want to find sentences");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a word tah you want to be  contained in sentences:");
            string word = Console.ReadLine();
            string[] sentences = text.Split('.');
            StringBuilder result = new StringBuilder();

            foreach (var item in sentences)
            {
                if (item.Contains(" "+word+" "))
                {
                    result.Append(item);
                    result.Append(".");
                }
            }
            Console.WriteLine(result);
        }
    }
}
