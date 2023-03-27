namespace CarManufacturer
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Car vehicle = new Car("VW", "MK3", 1992, 200, 200);
            vehicle.Drive(200);
            Console.WriteLine(vehicle.WhoAmI());
        }
    }
}
