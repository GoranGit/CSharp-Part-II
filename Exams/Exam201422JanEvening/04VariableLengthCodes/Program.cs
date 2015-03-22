using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableLengthCodes
{
    class Program
    {
        static void Main()
        {
            int[] integers = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray<int>();
            int l = int.Parse(Console.ReadLine());

            StringBuilder bitsArray = new StringBuilder();
            string table;
            List<char> charCode = new List<char>();
            List<int> intCode = new List<int>();
            for(int i=0;i<l;i++)
            {
                table =(Console.ReadLine());

                charCode.Add(table[0]);
                intCode.Add(int.Parse(table.Substring(1)));

            }


            for(int i=0;i<integers.Length;i++)
            {
                bitsArray.Append(Convert.ToString(integers[i], 2).PadLeft(8,'0'));
            }

            StringBuilder result = new StringBuilder();
            int count = 0;
         
            for(int i=0;i<bitsArray.Length;i++)
            {
                
               if(bitsArray[i]=='1')
               {
                   count++;
                  
               }
               else
                if(count!=0)
                {
                    
                    result.Append(charCode[intCode.IndexOf(count)]);
                    count = 0;
                }

            }

            Console.WriteLine(result.ToString());
                


        }

       
    }
}
