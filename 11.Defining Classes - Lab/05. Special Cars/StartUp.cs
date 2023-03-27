namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tirePacks = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            tirePacks = Tires(Console.ReadLine(), tirePacks);
            engines = Engines(Console.ReadLine(), engines);
            cars = Cars(Console.ReadLine(), cars, tirePacks, engines);
            List<Car> specialCars = Filter(cars);
            IO(specialCars);
        }
        private static List<Tire[]> Tires(string readLine, List<Tire[]> tirePacks)
        {
            if (readLine == "No more tires")
                return tirePacks;
            string[] tireYearAndPressure = readLine.Split();
            Tire[] singleTires = new Tire[4];
            int indexCounter = default;
            for (int curentTire = 0; curentTire < 4; curentTire++)
            {
                int tireYear = int.Parse(tireYearAndPressure[indexCounter]);
                indexCounter++;
                double pressureValue = double.Parse(tireYearAndPressure[indexCounter]);
                singleTires[curentTire] = new Tire(tireYear, pressureValue);
                indexCounter++;
            }
            tirePacks.Add(singleTires);
            return Tires(Console.ReadLine(), tirePacks);
        }
        private static List<Engine> Engines(string readLine, List<Engine> engines)
        {
            if (readLine == "Engines done")
                return engines;
            string[] engineInfo = readLine.Split();
            int horsePower = int.Parse(engineInfo[0]);
            double cubicCapacity = double.Parse(engineInfo[1]);
            engines.Add(new Engine(horsePower, cubicCapacity));
            return Engines(Console.ReadLine(), engines);
        }
        private static List<Car> Cars(string readLine, List<Car> cars, List<Tire[]> tirePacks, List<Engine> engines)
        {
            if (readLine == "Show special")
                return cars;
            string[] carInfo = readLine.Split();
            string make = carInfo[0];
            string model = carInfo[1];
            int year = int.Parse(carInfo[2]);
            double fuelQuantity = double.Parse(carInfo[3]);
            double fuelConsumption = double.Parse(carInfo[4]);
            int engineIndex = int.Parse(carInfo[5]);
            int tiresIndex = int.Parse(carInfo[6]);

            Tire[] currentCarTires = tirePacks[tiresIndex];
            Engine currentCarEngine = engines[engineIndex];
            cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, currentCarEngine, currentCarTires));
            return Cars(Console.ReadLine(), cars, tirePacks, engines);
        }
        private static List<Car> Filter(List<Car> cars)
            => cars.FindAll(c => c.Year >= 2017
                                       && c.Engine.HorsePower > 330
                                       && c.Tires.Select(t => t.Pressure).Sum() >= 9
                                       && c.Tires.Select(t => t.Pressure).Sum() <= 10);
        private static void IO(List<Car> specialCars)
        {
            foreach (Car car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car);
            }
        }
    }
}
