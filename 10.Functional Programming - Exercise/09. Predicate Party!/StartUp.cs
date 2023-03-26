namespace _09._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();
            names = ProcessCommands(Console.ReadLine(), names);
            GuestsCommingToTheParty(names);
        }
        static List<string> ProcessCommands(string input, List<string> names)
        {
            if (input == "Party!") 
                return names;

            string[] tokens = input.Split();
            string action = tokens[0];
            string condition = tokens[1];
            string value = tokens[2];

            Predicate<string> checker = PredicateBuilder(condition, value);
            Func<List<string>, List<string>> executeCommand = FunctionBuilder(action, checker);
            names = executeCommand(names);

            return ProcessCommands(Console.ReadLine(), names); 
        }

        static Predicate<string> PredicateBuilder(string condition, string value)
        {
            switch (condition)
            {
                case "StartsWith":
                    return x => x.StartsWith(value);
                case "EndsWith":
                    return x => x.EndsWith(value);
                case "Length":
                    return x => x.Length == int.Parse(value);
                default: 
                    return x => x == null;
            }
        }

        static Func<List<string>, List<string>> FunctionBuilder(string action, Predicate<string> checker)
        {
            switch (action)
            {
                case "Double":
                    return x =>
                    {
                        List<string> newList = new List<string>();
                        foreach (string item in x)
                        {
                            newList.Add(item);
                            if (checker(item))
                                newList.Add(item);
                        }
                        return newList;
                    };

                case "Remove":
                    return x => x.Where(element => !checker(element)).ToList();
                default:
                    return x => x = null;
            }
        }
        static void GuestsCommingToTheParty(List<string> guests)
        {
            Console.WriteLine(guests.Count > 0 ? String.Join(", ", guests) + " are going to the party!" : "Nobody is going to the party!");
        }
    }
}
