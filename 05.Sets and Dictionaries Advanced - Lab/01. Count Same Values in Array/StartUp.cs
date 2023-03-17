namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<double, int> countOfElementInArray;
            double[] arrayOfNumbers;
            GetInfo(out countOfElementInArray, out arrayOfNumbers);
            Engine(countOfElementInArray, arrayOfNumbers);
            IO(countOfElementInArray);
        }

        private static void GetInfo(out Dictionary<double, int> countOfElementInArray, out double[] arrayOfNumbers)
        {
            countOfElementInArray = new Dictionary<double, int>();
            arrayOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
        }

        private static void Engine(Dictionary<double, int> countOfElementInArray, double[] arrayOfNumbers)
        {
            foreach (var number in arrayOfNumbers)
            {
                if (!countOfElementInArray.ContainsKey(number))
                    countOfElementInArray.Add(number, 0);
                countOfElementInArray[number]++;
            }
        }

        private static void IO(Dictionary<double, int> countOfElementInArray)
        {
            foreach (var element in countOfElementInArray)
                Console.WriteLine($"{element.Key} - {element.Value} times");
        }
    }
}
