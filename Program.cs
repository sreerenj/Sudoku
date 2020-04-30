using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTestCases = Convert.ToInt32(Console.ReadLine());
            for(int t = 0; t < nTestCases; t++)
            {
                int[,] sudokuMatrix = new int[9,9];
                string[] sudokuVals = Console.ReadLine().Split(' ');
                int index = 0;
                for(int i = 0 ;i < 9; i++)
                {
                    for(int j= 0;j<9;j++)
                    {
                        sudokuMatrix[i,j] = Convert.ToInt32(sudokuVals[index++]);
                    }
                }

                for(int i=0;i<9;i++)
                {
                    for(int j=0;j<9;j++)
                    {
                        
                    }
                }
                for(int i = 0 ;i < 9; i++)
                {
                    for(int j= 0;j<9;j++)
                    {
                        Console.Write($"{sudokuMatrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
