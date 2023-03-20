namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Dictionary<string, SortedSet<string>> following, followedBy;
            Data(out following, out followedBy);
            Engine(following, followedBy);
            IO(following, followedBy);
        }

        private static void Data(out Dictionary<string, SortedSet<string>> following, out Dictionary<string, SortedSet<string>> followedBy)
        {
            following = new Dictionary<string, SortedSet<string>>();
            followedBy = new Dictionary<string, SortedSet<string>>();
        }

        private static void Engine(Dictionary<string, SortedSet<string>> following, Dictionary<string, SortedSet<string>> followedBy)
        {
            string inputFromConsole;
            while ((inputFromConsole = Console.ReadLine()) != "Statistics")
            {
                string firstName, action, secondName;
                GetInfo(inputFromConsole, out firstName, out action, out secondName);
                if (action == "joined" &&
                    !following.ContainsKey(firstName))
                {
                    following.Add(firstName, new SortedSet<string>());
                    followedBy.Add(firstName, new SortedSet<string>());
                }
                else if (action == "followed" &&
                         following.ContainsKey(firstName) &&
                         followedBy.ContainsKey(secondName) &&
                         firstName != secondName)
                {
                    following[firstName].Add(secondName);
                    followedBy[secondName].Add(firstName);
                }
            }
        }

        private static void GetInfo(string inputFromConsole, out string firstName, out string action, out string secondName)
        {
            firstName = inputFromConsole.Split()[0];
            action = inputFromConsole.Split()[1];
            secondName = inputFromConsole.Split()[2];
        }

        private static void IO(Dictionary<string, SortedSet<string>> following, Dictionary<string, SortedSet<string>> followedBy)
        {
            Console.WriteLine($"The V-Logger has a total of {following.Count} vloggers in its logs.");
            int ranking = 1;
            foreach (var vlogger in followedBy
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => following[x.Key].Count))
            {
                Console.WriteLine($"{ranking}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");
                if (ranking == 1)
                    Console.WriteLine(String.Join(Environment.NewLine, vlogger.Value.Select(x => $"*  {x}")));
                ranking++;
            }
        }
    }
}
