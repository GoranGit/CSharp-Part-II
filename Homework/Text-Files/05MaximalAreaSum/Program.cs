using System;
using System.IO;
// result of this task is in Debug/resut.txt
namespace _05MaximalAreaSum
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter file path: ");
            string inputFile = Console.ReadLine();
            int[,] ArrayOfInts = TransformInput(inputFile);
            int greatestSum = FindGreatestSum(ArrayOfInts);
            WriteFile(greatestSum);
        }


        private static int[,] TransformInput(string inputFile)
        {
            string[] Rows = ReadTheFile(inputFile);
            int[,] ArrayOfInts = new int[Rows.Length, Rows.Length];
            for (int row = 0; row < Rows.Length; row++)
            {
                string[] Temp = Rows[row].Split();
                for (int col = 0; col < Rows.Length; col++)
                {
                    ArrayOfInts[row, col] = int.Parse(Temp[col]);
                }
            }
           
            return ArrayOfInts;
        }

        private static string[] ReadTheFile(string inputFile)
        {
            StreamReader TheMatrix = new StreamReader(inputFile);
            string[] Rows;
            using (TheMatrix)
            {
                int size = int.Parse(TheMatrix.ReadLine());
                Rows = new string[size];
                for (int row = 0; row < size; row++)
                {
                    Rows[row] = TheMatrix.ReadLine();
                }
            }
            return Rows;
        }

        private static int FindGreatestSum(int[,] ArrayOfInts)
        {
            int sum = int.MinValue;
            for (int row = 0; row < ArrayOfInts.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < ArrayOfInts.GetLength(1) - 1; col++)
                {
                    int TempSum = ArrayOfInts[row, col] + ArrayOfInts[row, col + 1] + ArrayOfInts[row + 1, col] + ArrayOfInts[row + 1, col + 1];
                    if (sum < TempSum)
                    {
                        sum = TempSum;
                    }
                }
            }
            return sum;
        }

        private static void WriteFile(int greatestSum)
        {
            StreamWriter Result = new StreamWriter("result.txt");
            using (Result)
            {
                Result.WriteLine(greatestSum);
            }
        }

    }
}
