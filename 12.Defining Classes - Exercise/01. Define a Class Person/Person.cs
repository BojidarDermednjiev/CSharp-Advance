namespace DefiningClasses
{
    public class Person
    {
        private static string name;
        private static int age;
        public Person() { }
        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string WhoAmI()
            => $"Name: {Name}, Age: {Age}";
    }
}
