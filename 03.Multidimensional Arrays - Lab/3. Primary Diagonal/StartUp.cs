namespace _3._Primary_Diagonal
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int[,] matrix = GetInfo();
            FillMatrix(matrix);
            long maxSum = Accrual(matrix);
            IO(maxSum);
        }
        private static int[,] GetInfo()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            return matrix;
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = line[col];
            }
        }
        private static long Accrual(int[,] matrix)
        {
            long maxSum = default;
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    if (row == col)
                        maxSum += matrix[row, col];
            return maxSum;
        }
        private static void IO(long maxSum)
        {
            Console.WriteLine(maxSum);
        }
    }
}
