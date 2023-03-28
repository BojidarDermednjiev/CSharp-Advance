namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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
            this.People.Add(person);
        }
        public Person GetOldestMember()
            => People.OrderByDescending(x => x.Age).First();
        public List<Person> GetPeopleWhoAreMoreThenThirty()
            => People.FindAll(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        public string Print(List<Person> people)
        {
            var sb = new StringBuilder();
            foreach (var guy in people)
                sb.AppendLine($"{guy.Name} - {guy.Age}");
            return sb.ToString().TrimEnd();
        }
    }
}
