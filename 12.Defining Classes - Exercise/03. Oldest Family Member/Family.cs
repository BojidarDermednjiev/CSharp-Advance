using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People 
        {
            get => people;
            set => people = value;
        }
        public void AddMember(Person person) 
        {
            People.Add(person);
        }
        public Person GetOldestMember()
            => People.OrderByDescending(x => x.Age).First();
    }
}
