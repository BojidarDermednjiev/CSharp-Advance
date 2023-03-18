namespace _04._Product_Shop
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] sizeOfMatrix;
            string[,] matrix;
            GetInfo(out sizeOfMatrix, out matrix);
            FillMatrix(matrix);
            Engine(sizeOfMatrix, matrix);
        }
        private static void GetInfo(out int[] sizeOfMatrix, out string[,] matrix)
        {
            sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            matrix = new string[sizeOfMatrix[0], sizeOfMatrix[1]];
        }
        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = inputLine[col];
            }
        }
        private static void Engine(int[] sizeOfMatrix, string[,] matrix)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command.StartsWith("swap") && command.Split().Length == 5)
                {
                    int rowOne = int.Parse(command.Split()[1]);
                    int colOne = int.Parse(command.Split()[2]);
                    int rowTwo = int.Parse(command.Split()[3]);
                    int colTwo = int.Parse(command.Split()[4]);
                    if (rowOne >= 0 && rowOne < sizeOfMatrix[0] && colOne >= 0 && colOne < sizeOfMatrix[1] && rowTwo >= 0 && rowTwo < sizeOfMatrix[0] && colTwo >= 0 && colTwo < sizeOfMatrix[1])
                    {
                        (matrix[rowOne, colOne], matrix[rowTwo, colTwo]) = (matrix[rowTwo, colTwo], matrix[rowOne, colOne]);
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                                Console.Write(matrix[row, col] + " ");
                            Console.WriteLine();
                        }
                    }
                    else
                        IncorectMessage();
                }
                else
                    IncorectMessage();
            }
        }
        private static void IncorectMessage()
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
