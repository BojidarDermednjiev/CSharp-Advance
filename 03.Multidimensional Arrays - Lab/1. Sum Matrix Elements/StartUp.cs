namespace _1._Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[,] matrix;
            long totalSumFromElementInMatrix;
            GetInfo(out matrix, out totalSumFromElementInMatrix);
            FillMatrix(matrix);
            totalSumFromElementInMatrix = SumOperaion(matrix, totalSumFromElementInMatrix);
            IO(matrix, totalSumFromElementInMatrix);
        }
        private static void GetInfo(out int[,] matrix, out long totalSumFromElementInMatrix)
        {
            var sizeOfMatrix = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];
            totalSumFromElementInMatrix = default;
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentElementThanHaveToFillMatrix = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = currentElementThanHaveToFillMatrix[col];
            }
        }
        private static long SumOperaion(int[,] matrix, long totalSumFromElementInMatrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    totalSumFromElementInMatrix += matrix[row, col];
            return totalSumFromElementInMatrix;
        }
        private static void IO(int[,] matrix, long totalSumFromElementInMatrix)
        {
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(totalSumFromElementInMatrix);
        }
    }
}
