
//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
namespace _03CompareCharArrays
{
    class Program
    {
        static void Main()
        {
         
            char[] a = new char[100] ;
            char[] b = new char[100];
           
                Console.Write("Ente first array of integers separated by 'space':  ");
            string[] k = Console.ReadLine().Split(' ');
             Console.Write("Ente second array of integers separated by 'space':  ");
            string[] l = Console.ReadLine().Split(' ');

            int counter1  = 0;
            int counter2 = 0;
            foreach(string p in k)
            {
                a[counter1] = char.Parse(p); // elements in  first array 
                counter1++;
            }   
                 
            foreach(string p in l)
            {
                b[counter2] = char.Parse(p); // elements in  second array 
                counter2++;
            }

            bool minA = counter1<counter2 ? true : false;
        
            int minCount = counter1 < counter2 ? counter1 : counter2;

        
            for(int i =0;i<minCount;i++)
            {
                Console.WriteLine(a[i] == b[i]);
               
            }

          
        
        }
    }
}
