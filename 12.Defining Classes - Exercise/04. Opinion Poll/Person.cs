namespace DefiningClasses
{
    using System;
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.StartsWith(value.ToLower()))
                    throw new ArgumentException("Incorrect input for Name!");
                name = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 110)
                    throw new ArgumentException("Age cannot be negative number or more then 110 years!");
                age = value;
            }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        public override string ToString()
            => $"{this.Name} - {this.Age}";
    }
}