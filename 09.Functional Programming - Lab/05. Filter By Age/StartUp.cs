﻿namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class StartUp
    {
        static Func<string, Person> parseStringToPerson = name
            => new Person(name.Split(", ").First(), name.Split(", ").Skip(1).Select(age => int.Parse(age)).Last());
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int currentGuy = 0; currentGuy < numberOfPeople; currentGuy++)
                people.Add(parseStringToPerson(Console.ReadLine()));
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, age);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }

        public static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "younger")
                return x => x.Age < ageThreshold;
            else if(condition == "older")
                return x => x.Age >= ageThreshold;
            return null;
        }
        public static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Name);
                case "age":
                    return x => Console.WriteLine(x.Age);
                case "name age":
                    return x => Console.WriteLine($"{x.Name} - {x.Age}");
            }
            return null;
        }
        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            var filteredPeople = people.Where(x => filter(x)).ToList();
            foreach (var person in filteredPeople)
                printer(person);
        }
    }
}
