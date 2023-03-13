namespace _5._Print_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int[] inputLine = GetInfo();
            Queue<int> queue = Engine(inputLine);
            IO(queue);
        }
        private static int[] GetInfo()
            => Console.ReadLine().Split().Select(int.Parse).ToArray();
        private static Queue<int> Engine(int[] inputLine)
        {
            Queue<int> queue = new Queue<int>();
            for (int currentElement = 0; currentElement < inputLine.Length; currentElement++)
                if (inputLine[currentElement] % 2 == 0)
                    queue.Enqueue(inputLine[currentElement]);
            return queue;
        }
        private static void IO(Queue<int> queue)
        {
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
