namespace _06._Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int inputLines;
            HashSet<string> dataName;
            GetInfo(out inputLines, out dataName);
            FillHashSet(inputLines, dataName);
            PrintTheSpecialName(dataName);
        }

        private static void GetInfo(out int inputLines, out HashSet<string> dataName)
        {
            inputLines = int.Parse(Console.ReadLine());
            dataName = new HashSet<string>();
        }

        static void FillHashSet(int inputLines, HashSet<string> dataName)
        {
            string name;
            for (int currentInput = 0; currentInput < inputLines; currentInput++)
                dataName.Add(name = Console.ReadLine());    
        }
        static void PrintTheSpecialName(HashSet<string> dataName)
        {
            foreach (var name in dataName)
                Console.WriteLine(name);
        }
    }
}
