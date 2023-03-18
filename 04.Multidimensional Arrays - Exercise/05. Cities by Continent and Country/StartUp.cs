namespace _05._Cities_by_Continent_and_Country
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            char[,] matrix;
            int index;
            GetInfo(out matrix, out index);
            string snake = Console.ReadLine();
            Engine(matrix, index, snake);
            IO(matrix);
        }
        private static void GetInfo(out char[,] matrix, out int index)
        {
            var inputLineFromConsole = Console.ReadLine();
            int rows = int.Parse(inputLineFromConsole.Split()[0]);
            int cols = int.Parse(inputLineFromConsole.Split()[1]);
            matrix = new char[rows, cols];
            index = default;
        }
        private static void Engine(char[,] matrix, int index, string snake)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        index = FillMatrix(matrix, index, snake, row, col);
                else
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                        index = FillMatrix(matrix, index, snake, row, col);
            }
        }
        private static int FillMatrix(char[,] matrix, int index, string snake, int row, int col)
        {
            matrix[row, col] = snake[index++];
            if (index >= snake.Length)
                index = default;
            return index;
        }
        private static void IO(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write(matrix[row, col]);
                Console.WriteLine();
            }
        }
    }
}
