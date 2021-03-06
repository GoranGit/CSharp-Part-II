﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SolveTasks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter");
            Console.WriteLine("1--Reversing number");
            Console.WriteLine("2--Average of numbers");
            Console.WriteLine("3--Linear Equation");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    {
                        Console.WriteLine("Enter decimal number that is non-negative");
                        decimal num = decimal.Parse(Console.ReadLine());
                        if (num < 0)
                        {
                            Console.WriteLine("The number should be positive");
                            Main();
                        }
                        Console.WriteLine("The reversed number is" + Reverse(num));
                        Main();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter integer numbers separated with comma");
                        int[] num = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x)).ToArray();
                        if (num.Length == 0)
                        {
                            Console.WriteLine("You should enter one element at least");
                            Main();
                        }
                        Console.WriteLine("The average of the numbers is" + Average(num));
                        Main();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter a:");
                        int a = int.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            Console.WriteLine("a can not be zero");

                            Main();
                            break;
                        }
                        Console.WriteLine("enter b");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("x=" + LinearEquation(a, b));
                        Main();
                        break;
                    }
                default:
                    {
                        Main();
                        break;
                    }
            }
        }
        static decimal Reverse(decimal number)
        {
            string s = number.ToString();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new String(arr);
            return decimal.Parse(s);

        }
        static double Average(int[] numbers)
        {
            return numbers.Average();
        }
        static double LinearEquation(int a, int b)
        {
            return (-1) * b / a;


        }
    }
}