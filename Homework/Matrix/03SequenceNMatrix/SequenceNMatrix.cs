using System;
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
namespace _03SequenceNMatrix
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Add number of row:");
            int n = int.Parse(Console.ReadLine()); // number of row
            Console.Write("Add number of colums:");
            int m = int.Parse(Console.ReadLine());//number of colum
            string[,] matrix = new string[n,m];
            int count = 1;
            int maxCount = 1;

            string result = "";


            for(int i = 0; i < n;i++ )
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Add [{0},{1}] :", i, j);
                    matrix[i, j] = Console.ReadLine();
                    
                }

            }

            bool downLeft = false;
            bool downRight = false;
            bool down = false;
            bool right = false;

            for (int i = 0; i < n-1; i++)
			{
                for (int j = 0; j < m-1; j++)
			{
                count = 1;
                     if(i+1<n)
                     down =(matrix[i,j]==matrix[i+1,j]);
                   
                    if(j+1<m)
                    right = (matrix[i,j]==matrix[i,j+1]);
                    
                    if(i+1<n&&j+1<m)
                    downRight = (matrix[i,j]==matrix[i+1,j+1]);

                    if(i+1<n && j-1>=0)
                    downLeft = (matrix[i,j]==matrix[i+1,j-1]);

                    if(down)// check down
                    {
                        count++;
                         int p = i+2;
                        while(down)
                        {
                         
                            if (p > n - 1 || p < 0 )
                             break;
                            count++;
                            down = (matrix[i, j] == matrix[p++, j]);

                        }

                        if(count>maxCount)
                        {
                            result = matrix[i, j];
                            maxCount = count;
                        }
                        count = 1;
                    }
                    if(right) //check right
                    {
                        count++;
                        int p = j+2;
                        while (right)
                        {
                            
                            if (p > n - 1 || p < 0 )
                                break;
                            count++;
                            right = (matrix[i, j] == matrix[i, p++]);

                        }

                        if (count > maxCount)
                        {
                            result = matrix[i, j];
                            maxCount = count;
                        }

                        count = 1;
                    }
                    if(downRight) // check down right
                    {
                        count++;
                        int p = i + 2;
                        int q = j + 2;
                        while (downRight)
                        {
                            
                            if (p > n - 1 || p < 0 || q > m - 1 || q < 0)
                                break;
                            count++;
                            downRight = (matrix[i, j] == matrix[p++, q++]);

                        }

                        if (count > maxCount)
                        {
                            result = matrix[i, j];
                            maxCount = count;
                        }

                        count = 1;
                    }
                    if (downLeft)// check down left
                    {
                        count++;
                        int p = i + 2;
                        int q = j - 2;
                        while (downLeft)
                        {
                           
                            if (p > n - 1 || p < 0 || q > m - 1 || q < 0)
                                break;
                            count++;
                           downLeft = (matrix[i, j] == matrix[p++, q--]);

                        }

                        if (count > maxCount)
                        {
                            result = matrix[i, j];
                            maxCount = count;
                        }

                        count = 1;
                    }
			 
			}
			 
			}

            if (maxCount == 1)
                Console.WriteLine("All elements are  diferent in sequence!");

            for (int i = 0; i < maxCount; i++)
                Console.WriteLine(result);


        }
    }
}
