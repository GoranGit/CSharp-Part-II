using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace _01MultiverseCommunication
{
    class Program
    {
        static void Main()
        {
           List<string> numSys = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            List<int> intVal = new List<int>();

            string input = Console.ReadLine();

            StringBuilder check = new StringBuilder();

           for(int i =0;i<input.Length;i++)
            {
                check.Append(input[i]);
                if (numSys.Contains(check.ToString()))
                {
                    intVal.Add(numSys.IndexOf(check.ToString()));
                    check.Clear();
                }

            }

          intVal.Reverse();


           ulong result = 0;
           for (int i = 0; i < intVal.Count;i++ )
           {
               result += (ulong)intVal[i] * (ulong)Math.Pow(13, i);

           }

           Console.WriteLine(result);

        }
    }
}
