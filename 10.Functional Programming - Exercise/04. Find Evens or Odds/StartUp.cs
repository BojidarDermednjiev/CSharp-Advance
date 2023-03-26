namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));
        private static Predicate<int> isEven = x => x % 2 == 0;
        private static Predicate<int> isOdd = x => x % 2 != 0;
        private static Func<int, Predicate<int>, bool> isValid = (x, condition) => condition(x);
        private static List<int> result = new List<int>();
        static void Main()
        {
            int[] range;
            string condition;
            GetInfo(out range, out condition);
            Engine(range, condition);
            IO();
        }
        private static void GetInfo(out int[] range, out string condition)
        {
            range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            condition = Console.ReadLine();
        }
        private static void Engine(int[] range, string condition)
        {
            for (int currentNumber = range.First(); currentNumber <= range.Last(); currentNumber++)
                if (condition == "odd" && isValid(currentNumber, isOdd) || condition == "even" && isValid(currentNumber, isEven))
                    result.Add(currentNumber);
        }
        private static void IO()
        {
            print(result);
        }
    }
}
