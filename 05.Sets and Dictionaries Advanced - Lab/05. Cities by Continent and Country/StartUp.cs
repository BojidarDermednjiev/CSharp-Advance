namespace _05._Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var inputsFromConsole = int.Parse(Console.ReadLine());
            var citiesByContinetAndContry = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int currentInput = 0; currentInput < inputsFromConsole; currentInput++)
                GetInputFromConsole(citiesByContinetAndContry);
            PrintTheCitiesByContinentAndTheitCountries(citiesByContinetAndContry);
        }
        static Dictionary<string, Dictionary<string, List<string>>> GetInputFromConsole(Dictionary<string, Dictionary<string, List<string>>> citiesByContinetAndContry)
        {
            string input = Console.ReadLine();
            string continent = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
            string country = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
            string city = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
            if (!citiesByContinetAndContry.ContainsKey(continent))
                citiesByContinetAndContry.Add(continent, new Dictionary<string, List<string>>());
            if (!citiesByContinetAndContry[continent].ContainsKey(country))
                citiesByContinetAndContry[continent].Add(country, new List<string>());
            citiesByContinetAndContry[continent][country].Add(city);
            return citiesByContinetAndContry;
        }
        private static void PrintTheCitiesByContinentAndTheitCountries(Dictionary<string, Dictionary<string, List<string>>> citiesByContinetAndContry)
        {
            foreach (var continents in citiesByContinetAndContry)
            {
                Console.WriteLine($"{continents.Key}:");
                foreach (var country in continents.Value)
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");

            }
        }
    }
}
