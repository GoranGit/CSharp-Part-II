using System;
using System.Text;
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
namespace _07OneSystemToAnyOther
{
    class Program
    {
        enum Sys
        {
            A = 10, B, C, D, E, F

        };


        static void Main()
        {
            Console.WriteLine("Enter from system base s= ");
            int baseS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter to system base d=");
            int baseD = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();

            Console.WriteLine(FromDecToBaseD(baseD,FromBaseSToDec(baseS,num)));

        }
         static int FromBaseSToDec(int baseS,string num) 
         {
             num = num.ToUpper();
             char[] strNum = num.ToCharArray();
             Array.Reverse(strNum);
             int rezult = 0;

             for (int i = 0; i < num.Length; i++)
             {
                 if (!char.IsDigit(strNum[i]))
                 {
                     int x = (int)(strNum[i] - 55);
                     rezult += (x * (int)Math.Pow(baseS, i));
                 }
                 else
                 {
                     rezult += int.Parse(strNum[i].ToString()) * (int)Math.Pow(baseS, i);
                 }
             }

             return rezult;
         }

        static string FromDecToBaseD(int baseD,int num)
         {
             int rest = 0;
             StringBuilder result = new StringBuilder();
             while (num != 0)
             {
                 rest = num % baseD;
                 num /= baseD;

                 if (rest > 9)
                 {
                     Sys l = (Sys)rest;

                     result.Append(l);
                 }
                 else
                     result.Append( rest);
             }

             char[] rez = result.ToString().ToCharArray();
             Array.Reverse(rez);

             return new string(rez);

         }
    }
}
