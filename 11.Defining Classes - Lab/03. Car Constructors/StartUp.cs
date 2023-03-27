namespace CarManufacturer
{
    using _03._Car_Constructors;
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
            Car vehicleOne = new Car();
            Car vehicleTwo = new Car(make, model,year);
            Car vehicleThree = new Car(make, model,year, fuelQuantity, fuelConsumption);
        }
    }
}
