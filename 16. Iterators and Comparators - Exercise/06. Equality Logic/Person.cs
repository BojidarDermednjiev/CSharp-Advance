using System;
using System.Diagnostics.CodeAnalysis;

namespace _06._Equality_Logic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override int GetHashCode()
            => HashCode.Combine(this.Name, this.Age * 12435);

        public override bool Equals(object? obj)
            => obj is Person other && this.Name == other.Name && this.Age == other.Age;

        public int CompareTo([AllowNull] Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
                result = this.Age.CompareTo(other.Age);
            return result;
        }
    }
}
