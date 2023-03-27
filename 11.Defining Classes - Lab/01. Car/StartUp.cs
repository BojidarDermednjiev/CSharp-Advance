namespace CarManufacturer
{
    using _01._Car;
    using System;

    public class StartUp
    {
        static void Main()
        {
            Car vehicle = new Car("VW","MK3", 1992);
            Console.WriteLine(vehicle.WhoAmI());
        }
    }
}

