namespace _02._Average_Student_Grades
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string[,] matrix = GetInfo();
            FillTheMatrix(matrix);
            int coundOfSquares = Engine(matrix);
            IO(coundOfSquares);
        }
        private static string[,] GetInfo()
        {
            var arrayOfSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            (int rows, int cols) = (arrayOfSize[0], arrayOfSize[1]);
            string[,] matrix = new string[rows, cols];
            return matrix;
        }
        private static void FillTheMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = inputLine[col];
            }
        }
        private static int Engine(string[,] matrix)
        {
            int coundOfSquares = default;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                        coundOfSquares++;

            return coundOfSquares;
        }
        private static void IO(int coundOfSquares)
        {
            Console.WriteLine(coundOfSquares);
        }
    }
}
