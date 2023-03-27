namespace CarManufacturer
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            var tires = new Tire[4]
                {
                    new Tire(1, 2.5),
                    new Tire(1, 2.1),
                    new Tire(2, 0.5),
                    new Tire(2, 2.3),
                };
            var engine = new Engine(560, 3600);
            Car vehicleOne = new Car();
            Car vehicleTwo = new Car(make, model, year);
            Car vehicleThree = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Car vehicleFour = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
        }
    }
}
