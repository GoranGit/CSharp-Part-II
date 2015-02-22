using System;
namespace _02BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string bin = Console.ReadLine();

            Console.WriteLine(Convert.ToInt64(bin, 2));
            Console.WriteLine(ConvertToDec(bin));
        }

        static int ConvertToDec(string k)
        {
            
            char[] bin = k.ToCharArray();
            Array.Reverse(bin);
            int sumRez = 0;
            int subRez = 0;
            for (int i = 0; i < k.Length; i++)
            {
                subRez = (int.Parse(bin[i].ToString()) * (int)Math.Pow(2, i));
                sumRez += subRez;

            }
            return sumRez;

        }

    }



}
