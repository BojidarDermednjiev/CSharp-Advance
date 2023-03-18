namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int sizeOfNumber;
            int[,] matrix;
            GetInfo(out sizeOfNumber, out matrix);
            FillMatrix(matrix);
            double primaryDiagonal, secondaryDiagonal;
            Engine(sizeOfNumber, matrix, out primaryDiagonal, out secondaryDiagonal);
            IO(primaryDiagonal, secondaryDiagonal);
        }
        private static void GetInfo(out int sizeOfNumber, out int[,] matrix)
        {
            sizeOfNumber = int.Parse(Console.ReadLine());
            matrix = new int[sizeOfNumber, sizeOfNumber];
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var arrayOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = arrayOfNumbers[col];
            }
        }
        private static void Engine(int sizeOfNumber, int[,] matrix, out double primaryDiagonal, out double secondaryDiagonal)
        {
            primaryDiagonal = default;
            secondaryDiagonal = default;
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                        primaryDiagonal += matrix[row, col];
                    if ((row + col) == (sizeOfNumber - 1))
                        secondaryDiagonal += matrix[row, col];
                }
        }
        private static void IO(double primaryDiagonal, double secondaryDiagonal)
        {
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
