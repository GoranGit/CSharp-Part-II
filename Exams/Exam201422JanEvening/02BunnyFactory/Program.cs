using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02BunnyFactory
{
    class Program
    {
        static void Main()
        {
            int cagesN = 0;
            int inCage = 0;
            List<int> cages = new List<int>();
            BigInteger product = new BigInteger();
            StringBuilder arraay = new StringBuilder();
            BigInteger sum = 0;
            while(int.TryParse(Console.ReadLine(),out inCage))
            {
                
                cagesN++;
                cages.Add(inCage);
            }

            int numOfSums = 0;
            int sumS = 0;
            while(true)
            {
                numOfSums++;
                if(numOfSums> cages.Count)
                {
                     Console.WriteLine(string.Join(" ", cages));
                    return;
                }

                product = 1;
                sum = 0;
                sumS = 0;
                int i =0;
                int count = numOfSums;
                arraay.Clear();

                while(count!=0)
                {

                    sumS+=cages[i];
                    i++;
                    count--;
                }

                if(sumS>cages.Count - numOfSums)
                {
                    Console.WriteLine(string.Join(" ", cages));
                    return;
                }

                for (int j = numOfSums; j < numOfSums + sumS;j++ )
                {
                    sum +=(BigInteger) cages[j];
                    product *= BigInteger.Parse( cages[j].ToString());
                }




                arraay.Append(sum);
                arraay.Append(product);
               
                for(int j =numOfSums + sumS;j<cages.Count;j++)
                {
                    
                    arraay.Append(cages[j]);
                }

                for(int j=0; j<arraay.Length;j++)
                {
                    if((char)arraay[j]=='0'||(char)arraay[j]=='1')
                    {
                        arraay.Remove(j, 1);
                        j--;
                    }
                       
                }

                cages.Clear();

                for (int j = 0; j < arraay.Length;j++ )
                {
                    cages.Add(int.Parse(arraay[j].ToString()));
                }






            }


            
        }
    }
}
