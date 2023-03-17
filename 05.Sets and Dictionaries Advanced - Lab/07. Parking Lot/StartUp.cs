namespace _07._Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            HashSet<string> dataParking = GetInfo();
            Engine(dataParking);
            IO(dataParking);
        }
        private static HashSet<string> GetInfo()
            => new HashSet<string>();
        private static void Engine(HashSet<string> dataParking)
        {
            string inputLines;
            while ((inputLines = Console.ReadLine()) != "END")
            {
                string inOrOut = inputLines.Split(", ", StringSplitOptions.RemoveEmptyEntries).First();
                string carSerialNumber = inputLines.Split(", ", StringSplitOptions.RemoveEmptyEntries).Last();
                if (inOrOut == "IN")
                    dataParking.Add(carSerialNumber);
                else if (inOrOut == "OUT")
                    dataParking.Remove(carSerialNumber);
            }
        }
        private static void IO(HashSet<string> dataParking)
        {
            Console.WriteLine(dataParking.Any() ? string.Join(Environment.NewLine, dataParking) : "Parking Lot is Empty");
        }
    }
}
