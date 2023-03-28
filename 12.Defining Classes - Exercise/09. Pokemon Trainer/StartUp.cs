namespace _09._Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
                ReadNewTrainerInfo(trainers, input);
            while ((input = Console.ReadLine()) != "End")
                ReadCommands(trainers, input);
            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
                Console.WriteLine(trainer);
        }

        static void ReadNewTrainerInfo(List<Trainer> trainers, string input)
        {
            var command = new Queue<string>(input.Split());
            string trainerName = command.Dequeue();
            string pokemonName = command.Dequeue();
            string pokemonElement = command.Dequeue();
            int pokemonHealth = int.Parse(command.Dequeue());

            if (trainers.Any(t => t.Name == trainerName))
            {
                trainers
                    .Find(t => t.Name == trainerName).Pokemons
                    .Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }
            else
                trainers.Add(new Trainer(trainerName, pokemonName, pokemonElement, pokemonHealth));
        }

        static void ReadCommands(List<Trainer> trainers, string command)
        {
            for (int currentTrainer = 0; currentTrainer < trainers.Count; currentTrainer++)
            {
                if (trainers[currentTrainer].Pokemons.Any(p => p.Element == command))
                    trainers[currentTrainer].Badges++;
                else
                    DecreasePokemonsLifeBy10(trainers[currentTrainer].Pokemons);
            }
        }

        static void DecreasePokemonsLifeBy10(List<Pokemon> pokemons)
        {
            for (int currentPokemon = 0; currentPokemon < pokemons.Count; currentPokemon++)
            {
                pokemons[currentPokemon].Health -= 10;
                if (pokemons[currentPokemon].Health <= 0)
                    pokemons.RemoveAt(currentPokemon);
            }
        }
    }
}
