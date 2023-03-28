namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<Car> cars;
            int numberOfVehile;
            GetInfo(out cars, out numberOfVehile);
            Engine(cars, numberOfVehile);
            var typeOfVehicle = Console.ReadLine();
            IO(cars, typeOfVehicle);

        }
        private static void GetInfo(out List<Car> cars, out int numberOfVehile)
        {
            cars = new List<Car>();
            numberOfVehile = int.Parse(Console.ReadLine());
        }
        private static void Engine(List<Car> cars, int numberOfVehile)
        {
            for (int currentCar = 0; currentCar < numberOfVehile; currentCar++)
            {
                var vehicle = new Car();
                var engine = new Engine();
                var cargo = new Cargo();
                var tires = new Tire[4];
                string inputLine = Console.ReadLine();
                string model = inputLine.Split().First();
                int engineSpeed = int.Parse(inputLine.Split().Skip(1).First());
                int enginePower = int.Parse(inputLine.Split().Skip(2).First());
                engine = new Engine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(inputLine.Split().Skip(3).First());
                string cargoType = inputLine.Split().Skip(4).First();
                cargo = new Cargo(cargoType, cargoWeight);
                int inputIndex = 5;
                for (int currenTire = 0; currenTire < 4; currenTire++)
                {
                    double pressure = double.Parse(inputLine.Split()[inputIndex++]);
                    int age = int.Parse(inputLine.Split()[inputIndex++]);
                    tires[currenTire] = new Tire(age, pressure);
                }
                vehicle = new Car(model, engine, cargo, tires);
                cars.Add(vehicle);
            }
        }
        private static void IO(List<Car> cars, string typeOfVehicle)
        {
            Console.WriteLine(typeOfVehicle == "fragile" ? String.Join(Environment.NewLine, cars.FindAll(car => car.Cargo.Type == "fragile" &&
                                        car.Tires.Any(t => t.Pressure < 1))) : String.Join(Environment.NewLine, cars.FindAll(car =>
                            car.Cargo.Type == "flammable" &&
                            car.Engine.Power > 250)));
        }
    }
}
