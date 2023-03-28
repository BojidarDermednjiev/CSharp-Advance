namespace DefiningClasses
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            try
            {
                Family family = new Family();
                int numberOfPeople = int.Parse(Console.ReadLine());
                for (int currentMember = 1; currentMember <= numberOfPeople; currentMember++)
                {
                    var input = Console.ReadLine();
                    string name = input.Split().First();
                    int age = int.Parse(input.Split().Last());
                    Person person = new Person(name, age);
                    family.AddMember(person);
                }
                Person oldestMember = family.GetOldestMember();
                Console.WriteLine(oldestMember);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae);
            }
        }
    }
}
