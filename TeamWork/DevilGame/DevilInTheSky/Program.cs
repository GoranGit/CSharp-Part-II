using System;
using System.Threading;
using System.Drawing;
namespace DevilInTheSky
{
    class Program
    {
        static void Main()
        {
            Devil k = new Devil();
            int direction = 0;

            //  Set Console settings  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 120;




            string l = "";

            while (true)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (i == 1 || i == 29)
                        Console.WriteLine(new string('-', Console.WindowWidth -30));


                    if (i >= k.position.Y && i <= k.position.Y + 7)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            l += k.imageDevil[i - k.position.Y, j].ToString();
                        }

                        Console.WriteLine("{1}{2}{3}", "|", new string(' ', k.position.X), l, new string(' ', Console.WindowWidth-30 - k.position.X - 7));
                        l = "";
                    }
                    else
                        Console.WriteLine("|" + new string(' ',Console.WindowWidth - 32) + "|");
                }


                ConsoleKeyInfo secondPressedKey = new ConsoleKeyInfo();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo firstPressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        secondPressedKey = Console.ReadKey(true);
                    }

                    direction = changeDirection(firstPressedKey, secondPressedKey);
                    k.moveDevil(direction);

                }
                else
                {

                    k.moveDevil(direction);
                }


                Thread.Sleep(200);
                Console.Clear();
            }
        }



        static int changeDirection(ConsoleKeyInfo pressedKey, ConsoleKeyInfo pressedSecondKey)
        {
            if (pressedKey.Key == ConsoleKey.LeftArrow && pressedSecondKey.Key == 0)
            {
                return 3;
            }
            else
                if (pressedKey.Key == ConsoleKey.LeftArrow && pressedSecondKey.Key == ConsoleKey.UpArrow)
                {
                    return 5;
                }
                else
                    if (pressedKey.Key == ConsoleKey.LeftArrow && pressedSecondKey.Key == ConsoleKey.DownArrow)
                    {
                        return 7;
                    }


            if (pressedKey.Key == ConsoleKey.RightArrow && pressedSecondKey.Key == 0)
            {
                return 2;
            }
            else
                if (pressedKey.Key == ConsoleKey.RightArrow && pressedSecondKey.Key == ConsoleKey.UpArrow)
                {
                    return 4;
                }
                else
                    if (pressedKey.Key == ConsoleKey.RightArrow && pressedSecondKey.Key == ConsoleKey.DownArrow)
                    {
                        return 6;
                    }
            if (pressedKey.Key == ConsoleKey.UpArrow && pressedSecondKey.Key == 0)
            {
                return 0;
            }
            else
                if (pressedKey.Key == ConsoleKey.UpArrow && pressedSecondKey.Key == ConsoleKey.LeftArrow)
                {
                    return 5;
                }
                else
                    if (pressedKey.Key == ConsoleKey.UpArrow && pressedSecondKey.Key == ConsoleKey.RightArrow)
                    {
                        return 4;
                    }
            if (pressedKey.Key == ConsoleKey.DownArrow && pressedSecondKey.Key == 0)
            {
                return 1;
            }
            else
                if (pressedKey.Key == ConsoleKey.DownArrow && pressedSecondKey.Key == ConsoleKey.RightArrow)
                {
                    return 6;
                }
                else
                    if (pressedKey.Key == ConsoleKey.DownArrow && pressedSecondKey.Key == ConsoleKey.LeftArrow)
                    {
                        return 7;
                    }
            return 0;
        }

    }
}
