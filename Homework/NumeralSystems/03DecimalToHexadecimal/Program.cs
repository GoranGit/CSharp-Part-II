
using System;

namespace _03DecimalToHexadecimal
{
    class Program
    {
         enum Hex
        {
            A=10,B,C,D,E,F
            
        };
       

        static void Main()
        {
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(dec, 16));
            Console.WriteLine(ConverToHex(dec));
        }

        static string ConverToHex(int dec)
        {
            int rest = 0;
           string rezult = "";
            while(dec!=0)
            {
                rest = dec % 16;
                dec /= 16;

                if (rest > 9)
                {
                    Hex l = (Hex)rest;

                    rezult += l;
                }
                else
                    rezult += rest;
            }

            char[] rez = rezult.ToCharArray();
            Array.Reverse(rez);

            return new string(rez);

        }

    }
}
