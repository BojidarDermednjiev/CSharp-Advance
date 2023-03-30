namespace _07._Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string fullName, address, name;
            int litersOfBeer, integerValue;
            double doubleValue;
            GetInfo(out fullName, out address, out name, out litersOfBeer, out integerValue, out doubleValue);
            Tuple<string, string> firstTuple;
            Tuple<string, int> secondTuple;
            Tuple<int, double> thirdTuple;
            TupleValue(fullName, address, name, litersOfBeer, integerValue, doubleValue, out firstTuple, out secondTuple, out thirdTuple);
            IO(firstTuple, secondTuple, thirdTuple);
        }

        private static void IO(Tuple<string, string> firstTuple, Tuple<string, int> secondTuple, Tuple<int, double> thirdTuple)
        {
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }

        private static void GetInfo(out string fullName, out string address, out string name, out int litersOfBeer, out int integerValue, out double doubleValue)
        {
            string inputLineFromConsole = Console.ReadLine();
            fullName = string.Join(" ", inputLineFromConsole.Split().Take(2));
            address = inputLineFromConsole.Split().Last();
            inputLineFromConsole = Console.ReadLine();
            name = inputLineFromConsole.Split().First();
            litersOfBeer = int.Parse(inputLineFromConsole.Split().Last());
            inputLineFromConsole = Console.ReadLine();
            integerValue = int.Parse(inputLineFromConsole.Split().First());
            doubleValue = double.Parse(inputLineFromConsole.Split().Last());
        }
        private static void TupleValue(string fullName, string address, string name, int litersOfBeer, int integerValue, double doubleValue, out Tuple<string, string> firstTuple, out Tuple<string, int> secondTuple, out Tuple<int, double> thirdTuple)
        {
            firstTuple = new Tuple<string, string>(fullName, address);
            secondTuple = new Tuple<string, int>(name, litersOfBeer);
            thirdTuple = new Tuple<int, double>(integerValue, doubleValue);
        }
    }
}
