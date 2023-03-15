namespace _5._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int[,] matrix = GetInfo();
            FillMatrix(matrix);
            long maxSum;
            string bextSquar2x2;
            FindBiggestValue(matrix, out maxSum, out bextSquar2x2);
            IO(maxSum, bextSquar2x2);
        }
        private static int[,] GetInfo()
        {
            int[] demensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            (int rows, int cols) = (demensions[0], demensions[1]);
            int[,] matrix = new int[rows, cols];
            return matrix;
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = line[col];
            }
        }
        private static void FindBiggestValue(int[,] matrix, out long maxSum, out string bextSquar2x2)
        {
            maxSum = long.MinValue;
            bextSquar2x2 = string.Empty;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bextSquar2x2 = matrix[row, col] + " " + matrix[row, col + 1] + Environment.NewLine + matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
        }
        private static void IO(long maxSum, string bextSquar2x2)
        {
            Console.WriteLine(bextSquar2x2 + Environment.NewLine + maxSum);
        }
    }
}
