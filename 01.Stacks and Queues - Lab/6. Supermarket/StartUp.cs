namespace _6._Supermarket
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            Queue<string> clients = GetInfo();
            string inputLine;
            inputLine = Engine(clients);
            IO(clients);
        }
        private static Queue<string> GetInfo()
            => new Queue<string>();
        private static string Engine(Queue<string> clients)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine == "Paid")
                    for (int i = 0; i < clients.Count; i++)
                    {
                        foreach (var currentPerson in clients)
                            Console.WriteLine(currentPerson);
                        clients.Clear();
                    }
                else
                    clients.Enqueue(inputLine);
            }
            return inputLine;
        }
        private static void IO(Queue<string> clients)
        {
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
