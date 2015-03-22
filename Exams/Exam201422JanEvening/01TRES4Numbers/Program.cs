using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TRES4Numbers
{
    class Program
    {
        static void Main()
        {
            string[] nineSystemToStrings = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&","EMY>>", "/TEL", "<<DON" };


            ulong decNum = ulong.Parse(Console.ReadLine());

            if (decNum == 0)
            {
                Console.WriteLine(nineSystemToStrings[0]);
                return;
            }
            StringBuilder nineSys = new StringBuilder();
            while(decNum!=0)
            {
                nineSys.Append(decNum % 9);
                decNum /= 9;
            }

            string res = nineSys.ToString();
            char[] k = res.ToCharArray();
            Array.Reverse(k);
            nineSys.Clear();
            
           foreach(char e in k)
           {
               nineSys.Append(nineSystemToStrings[int.Parse(e.ToString())]);

           }
           Console.WriteLine(nineSys);
            

        }
    }
}
