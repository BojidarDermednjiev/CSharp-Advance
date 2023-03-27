namespace CarManufacturer
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
        private Engine engine;
        private Tire[] tire;
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
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
        public string Make { get => make; protected set => make = value; }
        public string Model { get => model; protected set => model = value; }
        public int Year { get => year; protected set => year = value; }
        public double FuelQuantity { get => fuelQuantity; protected set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; protected set => fuelConsumption = value; }
        public Engine Engine { get => engine; protected set => engine = value; }
        public Tire[] Tires { get => tire; protected set => tire = value; }
        public void Drive(double distance)
        {
            double fuelToSpend = distance * fuelConsumption / 100;
            if (fuelConsumption - fuelToSpend >= 0)
                fuelQuantity -= fuelToSpend;
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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}")
                .AppendLine($"Model: {Model}")
                .AppendLine($"Year: {Year}")
                .AppendLine($"HorsePower: {Engine.HorsePower}")
                .AppendLine($"Fuel: {FuelQuantity}");
            return sb.ToString().TrimEnd();
        }
    }
}
