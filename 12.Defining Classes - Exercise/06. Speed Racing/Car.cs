namespace _06._Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
        public double TravelDistance { get => travelledDistance; set => travelledDistance = value; }
        public Car() { }
        public Car(string model, double fuelAmount, double fuelConsumption, double travelDistance) : this()
        {
            Model= model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer= fuelConsumption;
            TravelDistance = 0;
        }
        public void Drive(double distance)
        {
            double fuelUse = distance * FuelConsumptionPerKilometer;
            if(FuelAmount - fuelUse < 0)
                System.Console.WriteLine("Insufficient fuel for the drive");
            else
            {
                FuelAmount -= fuelUse;
                TravelDistance += distance;
            }
        }
        public override string ToString()
            => $"{Model} {FuelAmount:f2} {TravelDistance}";
    }
}
