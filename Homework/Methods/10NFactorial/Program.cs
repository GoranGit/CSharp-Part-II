using System;
using System.Collections.Generic;
using System.Linq;
namespace _10NFactorial
{
    class Program
    {
        static void Main()
        {
            List<int> nFactorial = new List<int>();
            List<int> nextFac = new List<int>();

            nFactorial.Add(1);

            for(int i = 2;i<100;i++)
            {
                nextFac = new List<int>( Multiply(nFactorial.ToArray<int>(), i));
                Console.WriteLine(string.Join("",nextFac.ToArray<int>()));
                nFactorial = new List<int>(nextFac);
                
            }
                nFactorial.Add(0);
            nFactorial.Add(0);
            Console.WriteLine(string.Join("", nFactorial.ToArray<int>()));
            Console.ReadKey();
        }

        static List<int> Multiply(int[] array,int number)
        {
            int[] num = number.ToString().Select(x => int.Parse(x.ToString())).ToArray<int>();
            Array.Reverse(num);
            Array.Reverse(array);

            int[] biggerArray = array.Length > num.Length ? array : num;
            int[] smallerArray = array.Length > num.Length ? num : array;
          
            
           
            int reminder = 0;
            int subProduct = 0;
            List<int> subResult1 = new List<int>();
            List<int> subResult2 = new List<int>();

            List<int> result = new List<int>();
            int i = 0;
            bool firstNum = true;
            bool secondNum = false;

            for (int j = 0; j < smallerArray.Length; j++)
            {
                for (i = 0; i < biggerArray.Length; i++)
                {

                    subProduct = (smallerArray[j] * biggerArray[i] + reminder) % 10;
                    reminder = (smallerArray[j] * biggerArray[i] + reminder) / 10;
                    if(firstNum)
                    subResult1.Add(subProduct);
                    if (secondNum)
                        subResult2.Add(subProduct);

                   
                }
            
                    
                    if (firstNum)
                    {
                        if (reminder != 0)
                            subResult1.Add(reminder);
                        subResult2.Add(0);
                        secondNum = true;
                        firstNum = false;

                    }else
                        if (reminder != 0 && secondNum)
                        {
                            subResult2.Add(reminder);
                        }
                        

                reminder = 0;
            }

          

            return AddDigits(subResult1.ToArray<int>(), subResult2.ToArray<int>());


        }

        static List<int> AddDigits(int[] a, int[] b)
        {
            int reminder = 0;
            List<int> result = new List<int>();
            int n = a.Length > b.Length ? b.Length : a.Length;
            int rest = a.Length > b.Length ? a.Length : b.Length;
            int[] referToBigger = a.Length > b.Length ? a : b;


            int subSum = 0;
            int i = 0;
            for (i = 0; i < n; i++)
            {

                subSum = (a[i] + b[i] + reminder) % 10;
                result.Add(subSum);
                reminder = (a[i] + b[i] + reminder) / 10;
            }

            for (; i < rest; i++)
            {
                result.Add((referToBigger[i] + reminder) % 10);

                reminder = (referToBigger[i] + reminder) / 10;
            }
            if (reminder == 1)
                result.Add(1);

            result.Reverse();

            return result;

        }
    }
}
