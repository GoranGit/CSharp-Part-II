using System;
namespace _10UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                int k = s[i];
                Console.Write("\\u{0:X4}", k);
                
            }

        }
    }
}
