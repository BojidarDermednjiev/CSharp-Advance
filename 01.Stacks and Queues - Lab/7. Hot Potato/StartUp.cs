namespace _7._Hot_Potato
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        private static string player;
        private static Queue<string> queue;
        static void Main()
        {
            int number = GetInfo();
            Engine(number);
        }
        private static int GetInfo()
        {
            var players = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int number = int.Parse(Console.ReadLine());
            queue = new Queue<string>(players);
            return number;
        }
        private static void Engine(int number)
        {
            while (queue.Count > 1)
            {
                for (int currentPerson = 1; currentPerson < number; currentPerson++)
                {
                    var player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                player = queue.Dequeue();
                Console.WriteLine(IO(player));
            }
            player = queue.Dequeue();
            Console.WriteLine(IO(player));
        }
        private static string IO(string player)
            => queue.Count >= 1 ? $"Removed {player}" : $"Last is {player}";
    }
}
