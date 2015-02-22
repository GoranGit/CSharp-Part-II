using System;
namespace _05HexadecimalToBinary
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            Int64 h = Convert.ToInt64(hex, 16);
          Console.WriteLine(Convert.ToString(h, 2));
          Console.WriteLine(ConvertToBin(hex));
        }

        static string ConvertToBin(string hex)
        {
          hex =  hex.ToUpper();
            string p = "";
            string result = "";
            char [] h = hex.ToCharArray();

            if (hex.Equals("0"))
                return "0";

            for(int i=0;i<hex.Length;i++)
            {
                if( !char.IsDigit(h[i]))
                {
                    int r = (int)(h[i] - 55);
                    p = Convert.ToString(r, 2).PadLeft(4, '0');
                    result += p;
                }else
                {
                    p = Convert.ToString(int.Parse(h[i].ToString()), 2).PadLeft(4, '0');
                    result += p;
                }


            }
          result =  result.TrimStart('0');
          return result;
        }
    }
}
