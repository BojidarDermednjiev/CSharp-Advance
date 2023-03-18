namespace _06._Record_Unique_Names
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int rows;
            int[][] jaggedArrayMatrix;
            GetInfo(out rows, out jaggedArrayMatrix);
            FillJaggedArray(jaggedArrayMatrix);
            Engine(jaggedArrayMatrix);
            Operation(rows, jaggedArrayMatrix);
            IO(jaggedArrayMatrix);
        }
        private static void GetInfo(out int rows, out int[][] jaggedArrayMatrix)
        {
            jaggedArrayMatrix = new int[rows = int.Parse(Console.ReadLine())][];
        }
        private static void FillJaggedArray(int[][] jaggedArrayMatrix)
        {
            for (int row = 0; row < jaggedArrayMatrix.GetLength(0); row++)
                jaggedArrayMatrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        }
        private static void Engine(int[][] jaggedArrayMatrix)
        {
            for (int row = 0; row < jaggedArrayMatrix.GetLength(0) - 1; row++)
            {
                if (jaggedArrayMatrix[row].Length == jaggedArrayMatrix[row + 1].Length)
                {
                    jaggedArrayMatrix[row] = jaggedArrayMatrix[row].Select(x => x * 2).ToArray();
                    jaggedArrayMatrix[row + 1] = jaggedArrayMatrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArrayMatrix[row] = jaggedArrayMatrix[row].Select(x => x / 2).ToArray();
                    jaggedArrayMatrix[row + 1] = jaggedArrayMatrix[row + 1].Select(x => x / 2).ToArray();
                }
            }
        }
        private static void Operation(int rows, int[][] jaggedArrayMatrix)
        {
            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                var row = int.Parse(commands.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                var col = int.Parse(commands.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                var value = int.Parse(commands.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);
                if (Validation(rows, jaggedArrayMatrix, row, col))
                    jaggedArrayMatrix[row][col] = commands.StartsWith("Add") ? jaggedArrayMatrix[row][col] += value : jaggedArrayMatrix[row][col] -= value;
            }
        }
        private static bool Validation(int rows, int[][] jaggedArrayMatrix, int row, int col)
            => row >= 0 && row < rows && col >= 0 && col < jaggedArrayMatrix[row].Length;
        private static void IO(int[][] jaggedArrayMatrix)
        {
            foreach (var row in jaggedArrayMatrix)
                Console.WriteLine(String.Join(" ", row));
        }
    }
}
