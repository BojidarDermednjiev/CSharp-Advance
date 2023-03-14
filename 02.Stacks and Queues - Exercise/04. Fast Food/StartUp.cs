namespace _04._Fast_Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int quantityOfTheFood;
            Queue<int> queue;
            GetInfo(out quantityOfTheFood, out queue);
            PrintMaxQuantity(queue);
            Engine(quantityOfTheFood, queue);
            IO(queue);
        }
        private static void GetInfo(out int quantityOfTheFood, out Queue<int> queue)
        {
            quantityOfTheFood = int.Parse(Console.ReadLine());
            queue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
        }
        private static void Engine(int quantityOfTheFood, Queue<int> queue)
        {
            var count = queue.Count();
            for (int currentOrder = 0; currentOrder < count; currentOrder++)
            {
                if (quantityOfTheFood < queue.Peek())
                    continue;
                quantityOfTheFood -= queue.Peek();
                queue.Dequeue();
            }
        }
        private static void PrintMaxQuantity(Queue<int> queue)
        {
            Console.WriteLine(queue.Max());
        }
        private static void IO(Queue<int> queue)
        {
            Console.WriteLine(queue.Count == 0 ? "Orders complete" : "Orders left: " + string.Join(" ", queue));
        }
    }
}
