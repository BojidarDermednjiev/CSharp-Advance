namespace _03._Car_Constructors
{
    using System;
    using System.Text;
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public Car() { }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public string Make { get => make; protected set => make = value; }
        public string Model { get => model; protected set => model = value; }
        public int Year { get => year; protected set => year = value; }
        public double FuelQuantity { get => fuelQuantity; protected set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; protected set => fuelConsumption = value; }
        public void Drive(double distance)
        {
            double fuelToSpend = distance * this.fuelConsumption;
            if (this.fuelConsumption - fuelToSpend >= 0)
                this.fuelQuantity -= fuelToSpend;
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Year: {Year}")
                .AppendLine($"Fuel: {FuelQuantity:f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
