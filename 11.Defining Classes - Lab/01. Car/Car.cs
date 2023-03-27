using System.Text;

namespace _01._Car
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get => make; protected set => make = value; }
        public string Model { get => model; protected set => model = value; }
        public int Year { get => year; protected set => year = value; }
        public override string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"Year: {this.Year}");
            return sb.ToString().TrimEnd();
        }
    }
}
