namespace _08._SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        private static HashSet<string> vipGuest = new HashSet<string>();
        private static HashSet<string> regularGuest = new HashSet<string>();
        static void Main()
        {
            FillList();
            CheckToVisitTheGroup();
            PrintCountOfMissingPeople();
            PrintVipAndRegularMissingGuests();
        }
        static void FillList()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(inputLine[0]))
                    vipGuest.Add(inputLine);
                else
                    regularGuest.Add(inputLine);
            }

        }
        static void CheckToVisitTheGroup()
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                vipGuest.Remove(inputLine);
                regularGuest.Remove(inputLine);
            }
        }
        static void PrintCountOfMissingPeople()
        {
            Console.WriteLine(vipGuest.Count + regularGuest.Count);
        }
        static void PrintVipAndRegularMissingGuests()
        {
            if (vipGuest.Any())
                Console.WriteLine(String.Join(Environment.NewLine, vipGuest));
            if (regularGuest.Any())
                Console.WriteLine(String.Join(Environment.NewLine, regularGuest));
        }
    }
}
