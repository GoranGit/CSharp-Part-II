using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01KaspichanNumbers
{
    class Program
    {
        static void Main()
        {
            List<string> numSys = new List<string>();
            for(int i=0;i<26;i++)
            {
                numSys.Add(((char)(65 + i)).ToString());

            }

            int stopToV = 87;// V=86  +1

            int stop = 91;
            for(int j=97;j<106;j++)
            {
                if(j == 105)
                    stop = stopToV;

                for(int i=65;i<stop;i++)
                {
                   

                    numSys.Add(new string(new char[] { (char)j, (char)i }));
                }

            }

            ulong n = ulong.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            StringBuilder result = new StringBuilder();

            if(n==0)
            {
                result.Append('A');
                Console.WriteLine(result);
                return;
            }


            while(n!=0)
            {
                list.Add((int)(n % 256));
                n /= 256;

            }

            list.Reverse();

            for(int i=0;i<list.Count;i++)
            {
                result.Append(numSys[list[i]]);
            }


            Console.WriteLine(result);


        }
    }
}
