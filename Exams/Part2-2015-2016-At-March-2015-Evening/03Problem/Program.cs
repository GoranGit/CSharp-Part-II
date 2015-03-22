using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;

namespace _03Problem
{
    class Program
    {
        static void Main()
        {
            string[] dimension = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimension[0]);
            int cols = int.Parse(dimension[1]);

            List<string> direction = new List<string>();
            List<int> numOfMoves = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] dirMove = Console.ReadLine().Split(' ');
                direction.Add(dirMove[0]);
                numOfMoves.Add(int.Parse(dirMove[1]));
            }
            int rowAt = rows-1;
            int columAt = 0;

            BigInteger sum = 0;

            List<int[]> isVisited = new List<int[]>();
            ///////////

            int[,] matrixBool = new int[rows,cols];

            int[,] matrix = new int[rows, cols];

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j <= (cols - 1); j++)
                {

                    if (i == rows - 1 && j == 0)
                        continue;

                    if (i == rows - 1 && (j > 0 && j < cols))
                    {
                        matrix[i, j] = matrix[i, j - 1] + 3;
                    }
                    else
                        if (j == 0 && (i < rows - 1 && i >= 0))
                        {
                            matrix[i, j] = matrix[i + 1, j] + 3;
                        }
                        else
                        {
                            matrix[i, j] = matrix[i + 1, j] + 3;
                        }

                }

            }
            /////////////
         


            for(int i=0;i<direction.Count;i++)
            {
                for(int j =0;j<numOfMoves[i]-1;j++)
                {
                    int k = rowAt;
                    int c = columAt;

                    if (IsIn(rows, cols, direction[i], out rowAt, out columAt, k, c))
                    {


                           // if (!IsVisited(isVisited,rowAt,columAt))
                        //if (!isVisited.Contains(new int[]{rowAt,columAt}))
                        if(matrixBool[rowAt,columAt]==0)
                            {
                                sum += matrix[rowAt,columAt];
                                //isVisited.Add(new int[]{rowAt,columAt});
                                matrixBool[rowAt, columAt] = 1;

                            }
                    }
                    else
                        break;
                }
            }


            Console.WriteLine(sum);


        }
        static bool IsVisited(List<int[]> isVisited,int rowAt,int columAt)
        {

            for (int l = 0; l < isVisited.Count; l++)
            {
                if (isVisited[l][0] == rowAt && isVisited[l][1] == columAt)
                    return true;

            } return false;
        }

        static bool IsIn( int rows, int cols, string direction, out int rowAt, out int colAt , int a, int b)
        {

            rowAt = a;
            colAt = b;
            switch (direction)
            {
                case "UR":
                    {
                        if (rowAt - 1 >= 0 && colAt + 1 <= cols - 1)
                        {
                            rowAt--;
                            colAt++;

                            return true;
                        }
                        else
                            return false;
                    }
                case "RU":
                    {
                        if (rowAt - 1 >= 0 && colAt + 1 <= cols - 1)
                        {
                            rowAt--;
                            colAt++;

                            return true;
                        }
                        else
                            return false;
                    }


                case "UL":
                    {
                        if (rowAt - 1 >= 0 && colAt - 1 >= 0)
                        {
                           rowAt--;
                            colAt--;

                            return true;
                        }
                        else
                            return false;
                    }
                case "LU":
                    {
                        if (rowAt - 1 >= 0 && colAt - 1 >= 0)
                        {
                            rowAt--;
                           colAt--;

                            return true;
                        }
                        else
                            return false;
                    }
                case "DR":
                    {
                        if (rowAt + 1 <= rows - 1 && colAt + 1 < cols)
                        {
                            rowAt++;
                            colAt++;

                            return true;
                        }
                        else
                            return false;

                    }
                case "RD":
                    {
                        if (rowAt+ 1 <= rows - 1 && colAt + 1 < cols)
                        {
                            rowAt++;
                            colAt++;

                            return true;
                        }
                        else
                            return false;

                    }
                case "DL":
                    {
                        if (rowAt + 1 < rows && colAt - 1 >= 0)
                        {
                            rowAt++;
                            colAt--;

                            return true;

                        }
                        else
                            return false;
                    }
                case "LD":
                    {
                        if (rowAt + 1 < rows && colAt - 1 >= 0)
                        {
                            rowAt++;
                            colAt--;

                            return true;

                        }
                        else
                            return false;
                    }
            }
            return false;
        }
    }
}
