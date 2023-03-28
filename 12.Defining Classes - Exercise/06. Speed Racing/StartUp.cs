namespace _06._Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Car> vehicles = GetInfoAboutVehicle();
            vehicles = DriveAllCars(Console.ReadLine(), vehicles);
            IO(vehicles);
        }
        private static List<Car> GetInfoAboutVehicle()
        {
            List<Car> vehicles = new List<Car>();
            int numberOfVehicles = int.Parse(Console.ReadLine());
            for (int currentCar = 0; currentCar < numberOfVehicles; currentCar++)
            {
                var inputInfo = Console.ReadLine();
                var model = inputInfo.Split().First();
                var fuel = double.Parse(inputInfo.Split().Skip(1).First());
                var consumption = double.Parse(inputInfo.Split().Last());
                Car vehicle = new Car(model, fuel, consumption, 0);
                vehicles.Add(vehicle);
            }

            return vehicles;
        }
        private static List<Car> DriveAllCars(string inputLine, List<Car> vehicles)
        {
            if (inputLine == "End")
                return vehicles;
            string carModel = inputLine.Split().Skip(1).First();
            double distance = double.Parse(inputLine.Split().Last());
            Car currentCar = vehicles.Find(x => x.Model == carModel);
            currentCar.Drive(distance);
            return DriveAllCars(Console.ReadLine(), vehicles);
        }
        private static void IO(List<Car> vehicles)
        {
            vehicles.ForEach(x => Console.WriteLine(x));
        }
    }
}
