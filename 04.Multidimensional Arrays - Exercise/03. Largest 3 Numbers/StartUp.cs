using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int rowsCount, columnsCount;
            int[,] matrix;
            GetInfo(out rowsCount, out columnsCount, out matrix);
            FillTheMatrix(matrix);
            int rowIndex, colIndex, maxSum;
            Engine(rowsCount, columnsCount, matrix, out rowIndex, out colIndex, out maxSum);
            IO(matrix, rowIndex, colIndex, maxSum);
        }
        private static void GetInfo(out int rowsCount, out int columnsCount, out int[,] matrix)
        {
            var size = Console.ReadLine()
                 .Split(new[] { ' ' }
                     , StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();
            rowsCount = size[0];
            columnsCount = size[1];
            matrix = new int[rowsCount, columnsCount];
        }
        private static void FillTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = inputLine[col];
            }
        }
        private static void Engine(int rowsCount, int columnsCount, int[,] matrix, out int rowIndex, out int colIndex, out int maxSum)
        {
            rowIndex = default;
            colIndex = default;
            maxSum = default;
            for (int startRow = 0; startRow < rowsCount - 2; startRow++)
                for (var startColumn = 0; startColumn < columnsCount - 2; startColumn++)
                {
                    int currentRowSum = matrix[startRow, startColumn] + matrix[startRow, startColumn + 1] + matrix[startRow, startColumn + 2]
                              + matrix[startRow + 1, startColumn] + matrix[startRow + 1, startColumn + 1] + matrix[startRow + 1, startColumn + 2]
                              + matrix[startRow + 2, startColumn] + matrix[startRow + 2, startColumn + 1] + matrix[startRow + 2, startColumn + 2];

                    if (currentRowSum > maxSum)
                    {
                        maxSum = currentRowSum;
                        rowIndex = startRow;
                        colIndex = startColumn;
                    }
                }
        }
        private static void IO(int[,] matrix, int rowIndex, int colIndex, int maxSum)
        {
            Console.WriteLine($"Sum = {maxSum}" 
                + Environment.NewLine 
                + $"{matrix[rowIndex, colIndex]} " 
                + $"{matrix[rowIndex, colIndex + 1]} " 
                + $"{matrix[rowIndex, colIndex + 2]}" 
                + Environment.NewLine 
                + $"{matrix[rowIndex + 1, colIndex]} " 
                + $"{matrix[rowIndex + 1, colIndex + 1]} " 
                + $"{matrix[rowIndex + 1, colIndex + 2]}" 
                + Environment.NewLine 
                + $"{matrix[rowIndex + 2, colIndex]} " 
                + $"{matrix[rowIndex + 2, colIndex + 1]} " 
                + $"{matrix[rowIndex + 2, colIndex + 2]}" );
        }
    }
}
