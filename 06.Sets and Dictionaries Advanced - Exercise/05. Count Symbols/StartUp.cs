namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Dictionary<char, int> dataForAllSymbols;
            string inputLineFromConsole;
            GetInfo(out dataForAllSymbols, out inputLineFromConsole);
            FillDataForSymbols(dataForAllSymbols, inputLineFromConsole);
            IO(dataForAllSymbols);
        }
        private static void GetInfo(out Dictionary<char, int> dataForAllSymbols, out string inputLineFromConsole)
        {
            dataForAllSymbols = new Dictionary<char, int>();
            inputLineFromConsole = Console.ReadLine();
        }
        private static void FillDataForSymbols(Dictionary<char, int> dataForAllSymbols, string inputLineFromConsole)
        {
            foreach (char symbol in inputLineFromConsole)
            {
                if (!dataForAllSymbols.ContainsKey(symbol))
                    dataForAllSymbols.Add(symbol, 0);
                dataForAllSymbols[symbol]++;
            }
        }
        private static void IO(Dictionary<char, int> dataForAllSymbols)
        {
            foreach (var currentSymbol in dataForAllSymbols.OrderBy(x => x.Key))
                Console.WriteLine($"{currentSymbol.Key}: {currentSymbol.Value} time/s");
        }
    }
}
