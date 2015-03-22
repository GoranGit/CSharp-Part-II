using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                ReadNumber(1, 100);
            }
        }
    
        static void ReadNumber(int start, int end)
        {

            try{
                int k  = int.Parse(Console.ReadLine());
                if(start >=k || k>=end)
                {
                    throw new ArgumentOutOfRangeException();

                }
            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }   
    
    }
}
