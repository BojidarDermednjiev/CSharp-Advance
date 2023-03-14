namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        private static int countOfOperations;
        static void Main()
        {
            Stack<int> stack = GetInfo();
            stack = Engine(stack);
            Console.WriteLine(IO(stack));
        }
        private static Stack<int> GetInfo()
        {
            countOfOperations = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            return stack;
        }
        private static Stack<int> Engine(Stack<int> stack)
        {
            int[] tokents;
            for (int currentCommand = 0; currentCommand < countOfOperations; currentCommand++)
            {
                tokents = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                var command = tokents[0];
                if (command == 1)
                    Push(stack, tokents);
                else if (stack.Any())
                    AnotherCommnads(stack, command);
            }
            return stack;
        }
        private static void AnotherCommnads(Stack<int> stack, int command)
        {
            if (command == 2)
                stack.Pop();
            else if (command == 3)
                Console.WriteLine(stack.Max());
            else if (command == 4)
                Console.WriteLine(stack.Min());
        }
        private static void Push(Stack<int> stack, int[] tokents)
        {
            var element = tokents[1];
            stack.Push(element);
        }
        private static string IO(Stack<int> stack)
            => stack.Any() ? String.Join(", ", stack) : "0";
    }
}
