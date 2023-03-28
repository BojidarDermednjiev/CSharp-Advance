namespace DefiningClasses
{
    public class Person
    {
        private static string name;
        private static int age;
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this()
        {
            Age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string WhoAmI()
            => $"Name: {Name}, Age: {Age}";
    }
}
