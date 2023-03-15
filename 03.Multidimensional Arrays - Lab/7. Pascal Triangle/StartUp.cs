namespace _7._Pascal_Triangle
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var readNumberFromConsole = long.Parse(Console.ReadLine());
            PrintPascal(readNumberFromConsole);
        }
        public static long Pascal(int row, int col, Dictionary<string, long> memo)
        {
            string key = row + "," + col;
            if (memo.ContainsKey(key))
                return memo[key];
            else if (row == 0 || col == 0 || col == row)
            {
                memo[key] = 1;
                return 1;
            }
            else
            {
                long value = Pascal(row - 1, col - 1, memo) + Pascal(row - 1, col, memo);
                memo[key] = value;
                return value;
            }
        }
        public static void PrintPascal(long target)
        {
            var memo = new Dictionary<string, long>();
            for (int row = 0; row < target; row++)
            {
                for (int col = 0; col <= row; col++)
                    Console.Write(Pascal(row, col, memo) + " ");
                Console.WriteLine();
            }
        }
    }
}
