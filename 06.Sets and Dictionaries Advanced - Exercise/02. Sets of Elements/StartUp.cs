namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            HashSet<int> firstElements, secondElements;
            int firstLengthOfSeries, secondLengthOfSeries;
            GetInfo(out firstElements, out secondElements, out firstLengthOfSeries, out secondLengthOfSeries);
            FillHashSets(firstElements, secondElements, firstLengthOfSeries, secondLengthOfSeries);
            IO(firstElements, secondElements);
        }
        private static void GetInfo(out HashSet<int> firstElements, out HashSet<int> secondElements, out int firstLengthOfSeries, out int secondLengthOfSeries)
        {
            firstElements = new HashSet<int>();
            secondElements = new HashSet<int>();
            var intputLineFromConsole = Console.ReadLine();
            firstLengthOfSeries = intputLineFromConsole.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).First();
            secondLengthOfSeries = intputLineFromConsole.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Last();
        }
        private static void FillHashSets(HashSet<int> firstElements, HashSet<int> secondElements, int firstLengthOfSeries, int secondLengthOfSeries)
        {
            int inputLine;
            for (int currentElement = 0; currentElement < firstLengthOfSeries; currentElement++)
                firstElements.Add(inputLine = int.Parse(Console.ReadLine()));
            for (int currentElement = 0; currentElement < secondLengthOfSeries; currentElement++)
                secondElements.Add(inputLine = int.Parse(Console.ReadLine()));
        }
        private static void IO(HashSet<int> firstElements, HashSet<int> secondElements)
        {
            Console.WriteLine(String.Join(" ", firstElements.Intersect(secondElements)));
        }
    }
}
