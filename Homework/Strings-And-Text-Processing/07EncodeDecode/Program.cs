using System;
namespace _07EncodeDecode
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] key = Console.ReadLine().ToCharArray();
            Console.WriteLine(EncodeDecode(text, key));
            Console.WriteLine(EncodeDecode(EncodeDecode(text, key), key));

        }

        static string EncodeDecode(string text,char[] key)
        {
            char[] result = new char[text.Length];
            int j = 0;
            for(int i=0;i<text.Length;i++)
            {
                if(j==key.Length)
                    j = 0;
                result[i] = (char)((int)text[i] ^ (int)key[j]);

                
                
            }
            return new string(result);

        }
    }
}
