using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
namespace _03LoverOf3
{
    class Program
    {
        static void Main()
        {
            string[] dimension = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimension[0]);
            int cols = int.Parse(dimension[1]);

           
            int[,] boolMatrix = new int[rows, cols];
           int [,] matrix = new int[rows,cols];

            for(int i = rows-1;i>=0;i--)
            {
                for(int j=0;j<= (cols-1);j++)
                {

                    if (i == rows - 1 && j == 0)
                        continue;

                    if(i==rows-1 && (j>0 && j<cols))
                    {
                        matrix[i,j] = matrix[i,j-1] +3;
                    }else
                        if(j==0 && (i<rows-1 &&  i>=0))
                        {
                            matrix[i,j] = matrix[i+1,j] + 3;
                        }
                        else
                        {
                            matrix[i,j] = matrix[i+1,j]+3;
                        }
                   
                 }
               
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();
            }

            List<string> direction = new List<string>();
            List<int> numOfMoves = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for(int i =0;i<n;i++)
            {
                string[] dirMove = Console.ReadLine().Split(' ');
                direction.Add(dirMove[0]);
                numOfMoves.Add(int.Parse(dirMove[1]));
            }

           
            Point position = new Point(rows-1,0);

            BigInteger sum = 0;

            for(int i=0;i<direction.Count;i++)
            {
               
                for(int j = 0;j<numOfMoves[i];j++)
                {

                    if (IsIn(out position, rows, cols, direction[i], position.X, position.Y))
                    {
                        if (!IsVisited(position, boolMatrix))
                        {
                            sum += matrix[position.X, position.Y];
                            boolMatrix[position.X, position.Y] = 1;
                        }
                    }
                    else
                        break;
                

                }

            }

            Console.WriteLine(sum);

        }

        static bool IsIn(out Point pos,int rows,int cols, string direction, int x ,int y)
        {
            pos = new Point(x,y);

            switch(direction)
            {
                case "UR":
                    {
                        if (pos.X - 1 >= 0 && pos.Y + 1 <= cols - 1)
                        {
                            pos.X--;
                            pos.Y++;
                           
                            return true;
                        }
                        else
                            return false;
                    }
                case "RU":
                    {
                        if (pos.X - 1 >= 0 && pos.Y + 1 <= cols - 1)
                        {
                            pos.X--;
                            pos.Y++;

                            return true;
                        }
                        else
                            return false;
                    }


                case "UL":
                    {
                        if (pos.X - 1 >= 0 && pos.Y - 1 >= 0)
                        {
                            pos.X--;
                            pos.Y--;
                            
                            return true;
                        }
                        else
                            return false;
                    }
                case "LU":
                    {
                        if (pos.X - 1 >= 0 && pos.Y - 1 >= 0)
                        {
                            pos.X--;
                            pos.Y--;

                            return true;
                        }
                        else
                            return false;
                    }
                case "DR":
                    {
                        if (pos.X + 1 <= rows - 1 && pos.Y + 1 < cols)
                        {
                            pos.X++;
                            pos.Y++;
                           
                            return true;
                        }
                        else
                            return false;

                    }
                case "RD":
                    {
                        if (pos.X + 1 <= rows - 1 && pos.Y + 1 < cols)
                        {
                            pos.X++;
                            pos.Y++;

                            return true;
                        }
                        else
                            return false;

                    }
                case "DL":
                    {
                        if (pos.X + 1 < rows && pos.Y - 1 >= 0)
                        {
                            pos.X++;
                            pos.Y--;
                          
                            return true;

                        }
                        else
                            return false;
                    }
                case "LD":
                    {
                        if (pos.X + 1 < rows && pos.Y - 1 >= 0)
                        {
                            pos.X++;
                            pos.Y--;

                            return true;

                        }
                        else
                            return false;
                    }
            }
            return false;
        }
        static bool IsVisited(Point pos, int[,] matrixVis)
        {
            if (matrixVis[pos.X, pos.Y] != 0)
                return true;
            else
                return false;
        }
    }
}
