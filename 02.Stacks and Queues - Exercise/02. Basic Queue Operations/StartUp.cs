namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static int[] readNumbersFromConsole;
        private static List<int> numberList;
        static void Main()
        {
            int numberOfElementsToPush, numberOfElementsToPop, findElement;
            var queue = new Queue<int>();
            GetInfo(out numberOfElementsToPush, out numberOfElementsToPop, out findElement);
            Push(numberOfElementsToPush, queue);
            Pop(numberOfElementsToPop, queue);
            IO(queue, findElement);

        }
        private static void GetInfo(out int numberOfElementsToPush, out int numberOfElementsToPop, out int findElement)
        {
            readNumbersFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            numberList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            numberOfElementsToPush = readNumbersFromConsole[0];
            numberOfElementsToPop = readNumbersFromConsole[1];
            findElement = readNumbersFromConsole[2];
        }
        private static void Push(int numberOfElementsToPush, Queue<int> queue)
        {
            for (int currentElement = 0; currentElement < numberOfElementsToPush; currentElement++)
                queue.Enqueue(numberList[currentElement]);
        }
        private static void Pop(int numberOfElementsToPop, Queue<int> queue)
        {
            for (int currentElement = 0; currentElement < numberOfElementsToPop; currentElement++)
                queue.Dequeue();
        }
        private static void IO(Queue<int> queue, int findElement)
        {
            Console.WriteLine(queue.Any() ? IfContainsElement(queue, findElement) : "0");
        }
        private static string IfContainsElement(Queue<int> queue, int findElement)
            => queue.Contains(findElement) ? "true" : $"{queue.Min()}";
    }
}
