using System;
using System.Text;
namespace _09ForbiddenWords
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a text:");
            StringBuilder text =new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter forbidden words:");
            string forbWords = Console.ReadLine();
            forbWords = forbWords.Replace(" ", "");

            string[] words = forbWords.Split(',');

            foreach (var word in words)
            {
                string nude = new string('*', word.Length);
                text.Replace(word, nude);
                
            }

            Console.WriteLine(text);
        }
    }
}
