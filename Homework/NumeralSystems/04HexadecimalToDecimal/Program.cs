using System;

namespace _04HexadecimalToDecimal
{
    class Program
    {
       

        static void Main()
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hex, 16));
            Console.WriteLine(ConvertToDec(hex));
        }
        static int ConvertToDec(string hex)
        {
           hex = hex.ToUpper();
            char[] strHex = hex.ToCharArray();
            Array.Reverse(strHex);
            int rezult = 0;
            for(int i=0;i<hex.Length;i++)
            {
                if(!char.IsDigit(strHex[i]))
                {
                    int x = (int)(strHex[i] - 55);
                    rezult += (x * (int)Math.Pow(16, i));
                }
                else
                {
                   rezult+= int.Parse(strHex[i].ToString()) * (int)Math.Pow(16, i);
                }
            }

            return rezult;
        }
    }
}
