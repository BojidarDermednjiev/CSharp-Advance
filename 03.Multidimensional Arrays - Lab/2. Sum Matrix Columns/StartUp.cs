namespace _2._Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[,] matrix = GetInfo();
            FillMatrix(matrix);
            long[] totalOfElementsFromColInMatrix = Аccrual(matrix);
            IO(totalOfElementsFromColInMatrix);
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
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = line[col];
            }
        }
        private static long[] Аccrual(int[,] matrix)
        {
            long[] totalOfElementsFromColInMatrix = new long[matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    totalOfElementsFromColInMatrix[col] += matrix[row, col];
            }
            return totalOfElementsFromColInMatrix;
        }
        private static void IO(long[] totalOfElementsFromColInMatrix)
        {
            Console.WriteLine(String.Join(Environment.NewLine, totalOfElementsFromColInMatrix));
        }
    }
}
