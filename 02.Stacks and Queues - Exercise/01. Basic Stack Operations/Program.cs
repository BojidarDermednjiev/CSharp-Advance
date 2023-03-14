namespace _01._Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static int[] readNumbersFromConsole;
        private static List<int> numberList;
        static void Main()
        {
            int numberOfElementsToPush, numberOfElementsToPop, findElement;
            var stack = new Stack<int>();
            GetInfo(out numberOfElementsToPush, out numberOfElementsToPop, out findElement);
            Push(numberOfElementsToPush, stack);
            Pop(numberOfElementsToPop, stack);
            IO(stack, findElement);

        }
        private static void GetInfo(out int numberOfElementsToPush, out int numberOfElementsToPop, out int findElement)
        {
            readNumbersFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            numberList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            numberOfElementsToPush = readNumbersFromConsole[0];
            numberOfElementsToPop = readNumbersFromConsole[1];
            findElement = readNumbersFromConsole[2];
        }
        private static void Push(int numberOfElementsToPush, Stack<int> stack)
        {
            for (int currentElement = 0; currentElement < numberOfElementsToPush; currentElement++)
                stack.Push(numberList[currentElement]);
        }
        private static void Pop(int numberOfElementsToPop, Stack<int> stack)
        {
            for (int currentElement = 0; currentElement < numberOfElementsToPop; currentElement++)
                stack.Pop();
        }
        private static void IO(Stack<int> stack, int findElement)
        {
            Console.WriteLine(stack.Any() ? IfContainsElement(stack, findElement) : "0");
        }
        private static string IfContainsElement(Stack<int> stack, int findElement)
            => stack.Contains(findElement) ? "true" : $"{stack.Min()}";
    }
}
