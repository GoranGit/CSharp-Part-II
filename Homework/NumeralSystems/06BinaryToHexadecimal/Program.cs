using System;
namespace _06BinaryToHexadecimal
{
    class Program
    {

        enum Hex
        {
            A = 10, B, C, D, E, F

        };

        static void Main()
        {
            string bin = Console.ReadLine();
            Console.WriteLine(ConvertToHex(bin));

        }

        static string ConvertToHex(string bin)
        {
            
            char[] strBin = bin.ToCharArray();
       
            int counter = 0;
            string p="";
            string result = "";
            for(int i=0;i<bin.Length;i++)
            {
                counter++;
                if(counter==4)
                {
                 p    = strBin[i - 3].ToString() + strBin[i - 2].ToString() + strBin[i - 1].ToString() + strBin[i].ToString();
                int r= Convert.ToInt32(p, 2);

                if (r > 9)
                {
                    Hex x = (Hex)r;
                    result += x;
                }
                else
                    result += r;

                 counter = 0;
                    
                }

            }

            if(counter!=0)
            {
                switch(counter)
                {
                    case 1:
                        {
                            p = strBin[strBin.Length - 1].ToString();
                            break;
                        }
                    case 2:
                        {
                            p = strBin[strBin.Length - 2].ToString() + strBin[strBin.Length - 1].ToString();
                            break;
                        }
                    case 3:
                        {
                            p = strBin[strBin.Length - 3].ToString() + strBin[strBin.Length - 2].ToString() + strBin[strBin.Length - 1].ToString();
                            break;
                        }
                }
                int r = Convert.ToInt32(p, 2);
                result += r;
            }

            char[] rez = result.ToCharArray();
         
            return new string(rez);
        }

    }
}
