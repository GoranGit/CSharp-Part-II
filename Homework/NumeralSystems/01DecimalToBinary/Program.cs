using System;
using System.Text;
namespace _01DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            int dec = int.Parse(Console.ReadLine());

           Console.WriteLine(Convert.ToString(dec, 2));
           Console.WriteLine(ConvertToBin(dec));
        }
        static string ConvertToBin(int k)
        {
            StringBuilder rezult = new StringBuilder("");
            int reminder = 0;
            if (k == 0)
                return "0";

            while(k!=0)
            {
                reminder = k % 2;
                k /= 2;
                rezult.Append(reminder);


            }
            char[] rez = rezult.ToString().ToCharArray();
            Array.Reverse(rez);
            return new string(rez);
        }
    }
}
