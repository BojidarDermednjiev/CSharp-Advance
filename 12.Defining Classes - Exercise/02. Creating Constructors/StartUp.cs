namespace DefiningClasses
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();
            Console.WriteLine(person.WhoAmI());
            Console.WriteLine("Write your name: ");
            person.Name = Console.ReadLine();
            Console.WriteLine(person.WhoAmI());
            Console.WriteLine("Write your age: ");
                person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(person.WhoAmI());
        }
    }
}
