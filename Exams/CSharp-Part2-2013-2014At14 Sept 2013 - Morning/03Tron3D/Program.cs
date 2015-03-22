using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace _03Tron3D
{



    class Program
    {
        static void Main()
        {
            string dimensions = Console.ReadLine();

            string[] dim = dimensions.Split(' ');
            int X = int.Parse(dim[0]);
            int Y = int.Parse(dim[1]);
            int Z = int.Parse(dim[2]);

            string movesRed = Console.ReadLine();
            string movesBlue = Console.ReadLine();

            Point centerRed = new Point(X / 2, Y / 2);
            Point centerBlue = new Point(X / 2, Y + Z + Y / 2);


            bool firstMoved = false;
            bool secondMoved = false;

            Point headRed = centerRed;
            Point headBlue = centerBlue;
            int row = X + 1;
            int colum = 2 * Y + 2 * Z;

            int[,] matrix = new int[row, colum];
            // if value == 0-not visited, value == 1 - visited by red, if value== 2 visited by blue

            matrix[centerRed.X, centerRed.Y] = 1;
            matrix[centerBlue.X, centerBlue.Y] = 2;

            int directionRed = 2;//0-up to X for Y=0 edge, 1 - down to X edge for Y=Y, 2 - right , 3-left  
            int directionBlue = 3;

            int countRed = 0;
            int countBlue = 0;

            while (true) // each while  one  game cycle
            {
                while (movesRed[countRed] != 'M')
                {
                    directionRed = GetDirection(movesRed[countRed], directionRed);
                    countRed++;
                }
                if (movesRed[countRed] == 'M')
                {
                    directionRed = GetDirection(movesRed[countRed], directionRed);
                    firstMoved = Move(out headRed, headRed, directionRed, matrix, "red", row, colum); // return false if crashed
                    countRed++;
                }
                else
                    firstMoved = true;

                while (movesBlue[countBlue] != 'M')
                {
                    directionBlue = GetDirection(movesBlue[countBlue], directionBlue);
                    countBlue++;
                }

                if (movesBlue[countBlue] == 'M')
                {
                    directionBlue = GetDirection(movesBlue[countBlue], directionBlue);
                    secondMoved = Move(out headBlue, headBlue, directionBlue, matrix, "blue", row, colum);
                    countBlue++;
                }
                else
                    secondMoved = true;


                if ((!firstMoved && !secondMoved) || headBlue.Equals(headRed))
                {
                    Console.WriteLine("DRAW");

                    int distanceY = Math.Abs(headRed.Y - centerRed.Y) < (colum - Math.Abs(headRed.Y - centerRed.Y)) ? Math.Abs(headRed.Y - centerRed.Y) : (colum - Math.Abs(headRed.Y - centerRed.Y));

                    Console.WriteLine(Math.Abs(headRed.X - centerRed.X) + distanceY);
                    return;
                }
                else
                    if (!firstMoved && secondMoved)
                    {
                        Console.WriteLine("BLUE");


                        //for (int k = 0; k < row; k++)
                        //{
                        //    for (int p = 0; p < colum; p++)

                        //        Console.Write(matrix[k, p]);
                        //    Console.WriteLine();
                        //}

                        int distanceY = Math.Abs(headRed.Y - centerRed.Y) < (colum - Math.Abs(headRed.Y - centerRed.Y)) ? Math.Abs(headRed.Y - centerRed.Y) : (colum - Math.Abs(headRed.Y - centerRed.Y));

                        Console.WriteLine(Math.Abs(headRed.X - centerRed.X) + distanceY);
                        return;
                    }
                    else
                        if (firstMoved && !secondMoved)
                        {
                            Console.WriteLine("RED");

                            //for (int k = 0; k < row; k++)
                            //{
                            //    for (int p = 0; p < colum; p++)

                            //        Console.Write(matrix[k, p]);
                            //    Console.WriteLine();
                            //}

                            int distanceY = Math.Abs(headRed.Y - centerRed.Y) < (colum - Math.Abs(headRed.Y - centerRed.Y)) ? Math.Abs(headRed.Y - centerRed.Y) : (colum - Math.Abs(headRed.Y - centerRed.Y));

                            Console.WriteLine(Math.Abs(headRed.X - centerRed.X) + distanceY);
                            return;
                        }

            }



            //for (int k = 0; k < row; k++)
            //{
            //    for (int p = 0; p < colum; p++)

            //        Console.Write(matrix[k, p]);
            //    Console.WriteLine();
            //}








        }

        static bool Move(out Point h, Point head, int direction, int[,] matrix, string player, int rows, int colums)
        {


            switch (direction)
            {
                case 0:
                    {
                        head.X--;
                        break;
                    }
                case 1:
                    {
                        head.X++;
                        break;
                    }
                case 2:
                    {
                        head.Y++;
                        break;
                    }
                case 3:
                    {
                        head.Y--;
                        break;
                    }
            }

            if (head.Y > colums - 1)
                head.Y = 0;
            else
                if (head.Y < 0)
                    head.Y = colums - 1;



            h = new Point(head.X, head.Y);

            if (((head.X >= 0) && (head.X <= (rows - 1)) && (matrix[head.X, head.Y] != 0)) || head.X < 0 || head.X > (rows - 1))
            {
                if (h.X < 0)
                    h.X = 0;

                if (h.X > rows - 1)
                    h.X = rows - 1;

                return false;
            }


            if (player == "red")
                matrix[head.X, head.Y] = 1;
            if (player == "blue")
                matrix[head.X, head.Y] = 2;
            return true;

        }

        static int GetDirection(char move, int previousDir)
        {
            switch (previousDir)
            {
                case 0:
                    {
                        if (move == 'R')
                            return 2;
                        if (move == 'L')
                            return 3;
                        return 0;
                    }
                case 1:
                    {
                        if (move == 'L')
                            return 2;
                        if (move == 'R')
                            return 3;
                        return 1;

                    }
                case 2:
                    {
                        if (move == 'R')
                            return 1;
                        if (move == 'L')
                            return 0;
                        return 2;

                    }

                case 3:
                    {
                        if (move == 'R')
                            return 0;
                        if (move == 'L')
                            return 1;
                        return 3;


                    }
            }
            return -1;
        }
    }
}
