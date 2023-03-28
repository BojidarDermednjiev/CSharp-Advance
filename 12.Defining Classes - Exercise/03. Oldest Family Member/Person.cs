namespace DefiningClasses
{
    using System;
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
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Incorrect Name!");
                if (value.StartsWith(value.ToLower()))
                    throw new ArgumentException("Incorect Name!");
                name = value;
            }
        }
        public int Age 
        {
            get => age;
            set 
            {
                if (value < 0 || value > 110)
                    throw new ArgumentException("Incorrect Age! --- Age cannot be negative number!");
                age = value;
            } 
        }
        public override string ToString()
            => $"Name: {Name}, Age: {Age}";
    }
}
