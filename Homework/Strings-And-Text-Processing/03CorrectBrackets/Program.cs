using System;
using System.Linq;
namespace _03CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int indexOfClosed = 0;
            bool first = true;
            int countOpen = expression.Where(x=>x=='(').Count();
            int countClosed = expression.Where(x=>x==')').Count();

            if (countOpen != countClosed)
            {

                Console.WriteLine("Incorrect!");
                return;
            }
            else
            {
                for(int i=0;i<expression.Length;i++)
                {
                    if (expression[i] == '(')
                    {
                        
                        if (indexOfClosed < i)
                            indexOfClosed = i;

                        if (expression.IndexOf(')', indexOfClosed) == -1)
                        {
                            Console.WriteLine("Not correct!");
                            return;
                        }
                        else
                        
                           
                            if ((expression.IndexOf(')', indexOfClosed)) != -1)
                            {
                               
                                    indexOfClosed = expression.IndexOf(')', indexOfClosed) + 1;
                                
                                   
                            }
                            else
                            {
                                Console.WriteLine("InCorrect!");
                                return;
                            }
                        }   
                    }
                }
                Console.WriteLine("Correct!");

            }
  
        }
    }

