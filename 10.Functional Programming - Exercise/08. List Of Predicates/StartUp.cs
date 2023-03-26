namespace _08._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Action<Stack<int>> print;
            Stack<int> outcome;
            int maxRange;
            int[] dividers;
            GetInfo(out print, out outcome, out maxRange, out dividers);
            Engine(outcome, maxRange, dividers);
            IO(print, outcome);
        }
        private static void GetInfo(out Action<Stack<int>> print, out Stack<int> outcome, out int maxRange, out int[] dividers)
        {
            print = elements => Console.WriteLine(String.Join(" ", elements.Reverse()));
            outcome = new Stack<int>();
            maxRange = int.Parse(Console.ReadLine());
            dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        }
        private static void Engine(Stack<int> outcome, int maxRange, int[] dividers)
        {
            for (int currentNumber = 1; currentNumber <= maxRange; currentNumber++)
            {
                Predicate<int> isDivisible = x => currentNumber % x == 0;
                outcome.Push(currentNumber);
                for (int currentDividerNumber = 0; currentDividerNumber < dividers.Length; currentDividerNumber++)
                    if (!isDivisible(dividers[currentDividerNumber]))
                    {
                        outcome.Pop();
                        break;
                    }
            }
        }
        private static void IO(Action<Stack<int>> print, Stack<int> outcome)
        {
            print(outcome);
        }
    }
}
