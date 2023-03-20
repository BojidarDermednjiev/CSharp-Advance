namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            HashSet<string> dataForChemicalElements;
            int countOfChemicalElement;
            GetInfo(out dataForChemicalElements, out countOfChemicalElement);
            FillChemicalList(dataForChemicalElements, countOfChemicalElement);
            IO(dataForChemicalElements);
        }
        private static void GetInfo(out HashSet<string> dataForChemicalElements, out int countOfChemicalElement)
        {
            dataForChemicalElements = new HashSet<string>();
            countOfChemicalElement = int.Parse(Console.ReadLine());
        }
        private static void FillChemicalList(HashSet<string> dataForChemicalElements, int countOfChemicalElement)
        {
            for (int currentChemicalElement = 0; currentChemicalElement < countOfChemicalElement; currentChemicalElement++)
            {
                var inputLineFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var chemicalElement in inputLineFromConsole)
                    dataForChemicalElements.Add(chemicalElement);
            }
        }
        private static void IO(HashSet<string> dataForChemicalElements)
        {
            Console.WriteLine(String.Join(" ", dataForChemicalElements.OrderBy(x => x)));
        }
    }
}
