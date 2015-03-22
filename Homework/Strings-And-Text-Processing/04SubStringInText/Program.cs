using System;
namespace _04SubStringInText
{
    class Program
    {
        static void Main()
        {
            string text= Console.ReadLine();
            string subStr = Console.ReadLine();

            text = text.ToLower();
            subStr = subStr.ToLower();
            if(!text.Contains(subStr))
            {
                Console.WriteLine("0");
                return;
            }

            char [] p = subStr.ToCharArray();
            string[] k = new string[]{new string(p)};
            string[] count = text.Split(k,System.StringSplitOptions.None);
            Console.WriteLine(count.Length - 1);
        }
    }
}
