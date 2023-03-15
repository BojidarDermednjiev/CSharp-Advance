namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int number;
            int[][] jaggedArray;
            GetInfo(out number, out jaggedArray);
            FillJA(number, jaggedArray);
            Engine(jaggedArray);
            PrintJA(jaggedArray);
        }
        private static void GetInfo(out int number, out int[][] jaggedArray)
        {
            number = int.Parse(Console.ReadLine());
            jaggedArray = new int[number][];
        }
        private static void FillJA(int number, int[][] jaggedArray)
        {
            for (int rows = 0; rows < number; rows++)
                jaggedArray[rows] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        private static void Engine(int[][] jaggedArray)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int value = int.Parse(command.Split()[3]);
                if (row < 0 || row >= jaggedArray.GetLength(0) || col < 0 || col >= jaggedArray[row].Length)
                    Console.WriteLine("Invalid coordinates");
                else if (command.StartsWith("Add"))
                    jaggedArray[row][col] += value;
                else if (command.StartsWith("Subtract"))
                    jaggedArray[row][col] -= value;
            }
        }
        private static void PrintJA(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
                Console.WriteLine(string.Join(" ", row));
        }
    }
}
