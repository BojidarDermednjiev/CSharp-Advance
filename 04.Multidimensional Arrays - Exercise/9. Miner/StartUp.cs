namespace _9._Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Stack<string> commands = ReadCommands();
            char[,] field = GetFieldData(size);
            int[] startingPosition = GetCoordinatesOfTheMiner(field);

            Miner miner = new Miner();
            miner.CoalsLeft = GetTotalNumberOfCoals(field);
            miner.RowIndex = startingPosition[0];
            miner.ColIndex = startingPosition[1];
            int currentChar = 's';

            while (commands.Count > 0 &&
                   miner.CoalsLeft > 0 &&
                   currentChar != 'e')
            {
                string command = commands.Pop();
                miner.Move(command, size);
                currentChar = field[miner.RowIndex, miner.ColIndex];

                if (currentChar == 'c')
                {
                    miner.CoalsLeft--;
                    field[miner.RowIndex, miner.ColIndex] = '*';
                }
            }
            PrintOutput(miner, currentChar == 'e');
        }
        static Stack<string> ReadCommands()
        {
            Stack<string> commands = new Stack<string>();
            string[] line = Console.ReadLine().Split();
            for (int i = line.Length - 1; i >= 0; i--)
                commands.Push(line[i]);
            return commands;
        }
        static char[,] GetFieldData(int size)
        {
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                    field[row, col] = line[col];
            }
            return field;
        }
        static int GetTotalNumberOfCoals(char[,] field)
        {
            int coals = default;
            foreach (char c in field)
            {
                if (c == 'c') coals++;
            }
            return coals;
        }
        static int[] GetCoordinatesOfTheMiner(char[,] field)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 's')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        return coordinates;
                    }
                }
            }
            return coordinates;
        }
        static void PrintOutput(Miner miner, bool minerReachedTheEnd)
        {
            if (miner.CoalsLeft == 0)
                Console.Write($"You collected all coals! ");
            else if (minerReachedTheEnd)
                Console.Write($"Game over! ");
            else
                Console.Write($"{miner.CoalsLeft} coals left. ");

            Console.WriteLine($"({miner.RowIndex}, {miner.ColIndex})");
        }
    }
    class Miner
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public int CoalsLeft { get; set; }
        public void Move(string command, int matrixSize)
        {
            if (command == "up" && this.RowIndex > 0)
                this.RowIndex--;
            else if (command == "down" && this.RowIndex < matrixSize - 1)
                this.RowIndex++;
            else if (command == "left" && this.ColIndex > 0)
                this.ColIndex--;
            else if (command == "right" && this.ColIndex < matrixSize - 1)
                this.ColIndex++;
        }
    }
}
