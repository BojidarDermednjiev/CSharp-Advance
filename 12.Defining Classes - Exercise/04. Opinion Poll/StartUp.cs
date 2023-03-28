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
                ;
                for (int currentMember = 1; currentMember <= numberOfPeople; currentMember++)
                {
                    var input = Console.ReadLine();
                    string name = input.Split().First();
                    int age = int.Parse(input.Split().Last());
                    Person person = new Person(name, age);
                    family.AddMember(person);
                }
                ;
                var filter = family.GetPeopleWhoAreMoreThenThirty();
                
                Console.WriteLine(family.Print(filter));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae);
            }
        }
    }
}
