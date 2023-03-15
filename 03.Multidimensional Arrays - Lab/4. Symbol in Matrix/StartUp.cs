namespace _4._Symbol_in_Matrix
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            char[,] matrix = GetInfo();
            FillMatrix(matrix);
            bool isMatchingSymbol = default;
            char symbolForMaching = char.Parse(Console.ReadLine());
            isMatchingSymbol = FindSymbol(matrix, isMatchingSymbol, symbolForMaching);
            IO(symbolForMaching, isMatchingSymbol);
        }
        private static char[,] GetInfo()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
            return matrix;
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = inputLine[col];
            }
        }
        private static bool FindSymbol(char[,] matrix, bool isMatchingSymbol, char symbolForMaching)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    if (symbolForMaching == matrix[row, col])
                    {
                        isMatchingSymbol = true;
                        Console.WriteLine($"({row}, {col})");
                        return isMatchingSymbol;
                    }
            return isMatchingSymbol;
        }
        private static void IO(char symbolForMaching, bool isMatchingSymbol)
        {
            Console.WriteLine(isMatchingSymbol ? string.Empty: $"{symbolForMaching} does not occur in the matrix");
        }
    }
}
