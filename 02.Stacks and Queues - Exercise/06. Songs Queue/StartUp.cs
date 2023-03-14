namespace _06._Songs_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Queue<string> queue = GetMusicList();
            Engine(queue);
            FinalMessage();
        }

        private static Queue<string> GetMusicList()
            => new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
        private static void Engine(Queue<string> queue)
        {
            while (queue.Any())
            {
                var command = Console.ReadLine();
                if (command == "Play")
                    queue.Dequeue();
                else if (command.Contains("Add"))
                {
                    string song = string.Join("", command.Skip(4));
                    if (queue.Contains(song))
                        Console.WriteLine($"{song} is already contained!");
                    else
                        queue.Enqueue(song);
                }
                else if (command == "Show")
                    Console.WriteLine(string.Join(", ", queue));
            }
        }
        private static void FinalMessage()
        {
            Console.WriteLine("No more songs!");
        }
    }
}
