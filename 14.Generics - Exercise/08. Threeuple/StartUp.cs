namespace _08._Threeuple
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string fullName, address, town, drunkName, name, bankName;
            int litersOfBeer;
            bool isDrunk;
            double balance;
            GetUnfo(out fullName, out address, out town, out drunkName, out litersOfBeer, out isDrunk, out name, out balance, out bankName);
            Threeuple<string, string, string> firstThreeuple;
            Threeuple<string, int, bool> secondThreeuple;
            Threeuple<string, double, string> thirdThreeupl;
            TupleData(fullName, address, town, drunkName, name, bankName, litersOfBeer, isDrunk, balance, out firstThreeuple, out secondThreeuple, out thirdThreeupl);
            IO(firstThreeuple, secondThreeuple, thirdThreeupl);
        }
        private static void GetUnfo(out string fullName, out string address, out string town, out string drunkName, out int litersOfBeer, out bool isDrunk, out string name, out double balance, out string bankName)
        {
            string inputLineFromConsole = Console.ReadLine();
            fullName = string.Join(" ", inputLineFromConsole.Split().Take(2));
            address = inputLineFromConsole.Split().Skip(2).First();
            town = inputLineFromConsole.Split().Last();
            inputLineFromConsole = Console.ReadLine();
            drunkName = inputLineFromConsole.Split().First();
            litersOfBeer = int.Parse(inputLineFromConsole.Split().Skip(1).First());
            isDrunk = inputLineFromConsole.Split().Last() == "drunk" ? true : false;
            inputLineFromConsole = Console.ReadLine();
            name = inputLineFromConsole.Split().First();
            balance = double.Parse(inputLineFromConsole.Split().Skip(1).First());
            bankName = inputLineFromConsole.Split().Last();
        }
        private static void TupleData(string fullName, string address, string town, string drunkName, string name, string bankName, int litersOfBeer, bool isDrunk, double balance, out Threeuple<string, string, string> firstThreeuple, out Threeuple<string, int, bool> secondThreeuple, out Threeuple<string, double, string> thirdThreeupl)
        {
            firstThreeuple = new Threeuple<string, string, string>(fullName, address, town);
            secondThreeuple = new Threeuple<string, int, bool>(drunkName, litersOfBeer, isDrunk);
            thirdThreeupl = new Threeuple<string, double, string>(name, balance, bankName);
        }

        private static void IO(Threeuple<string, string, string> firstThreeuple, Threeuple<string, int, bool> secondThreeuple, Threeuple<string, double, string> thirdThreeupl)
        {
            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeupl);
        }
    }
}
