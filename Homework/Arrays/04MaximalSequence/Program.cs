
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
namespace _04MaximalSequence
{
    class Program
    {
        static void Main()
        {
            int maxElements = 20;
           string[] p  = Console.ReadLine().Split(',');
           int[] array  = new int[maxElements];
            int count =0;
           
            foreach(string k in p)
            {
                array[count] = int.Parse(k);
                count++;
            }

            int i = 0;
            int countSequence = 1;
            int maxElementsInSeq = 0;
            int maxPositionInArray = 0;
           
            while(i<p.Length -1)
            {
                while(i<p.Length-1 && (array[i] == array[i+1]))
                {
                    countSequence++;
                    i++;

                }

                if (maxElementsInSeq < countSequence)
                {
                    maxElementsInSeq = countSequence;
                    maxPositionInArray = i;
                }
                countSequence = 1;
                i++;

            }

            for (int j = maxPositionInArray; j >= maxPositionInArray - maxElementsInSeq + 1; j--)
                Console.Write(array[j]+",");


                
        }
    }
}
