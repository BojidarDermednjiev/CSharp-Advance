namespace _04._Even_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<int> collection;
            int lengthOfCollection;
            GetInfo(out collection, out lengthOfCollection);
            FillCollection(collection, lengthOfCollection);
            int repeatElemen = SearchingForRepeatItems(collection);
            Console.WriteLine(IO(repeatElemen));
        }
        private static void GetInfo(out List<int> collection, out int lengthOfCollection)
        {
            collection = new List<int>();
            lengthOfCollection = int.Parse(Console.ReadLine());
        }
        private static void FillCollection(List<int> collection, int lengthOfCollection)
        {
            for (int currentNumber = 0; currentNumber < lengthOfCollection; currentNumber++)
            {
                int inputFromConsole;
                collection.Add(inputFromConsole = int.Parse(Console.ReadLine()));
            }
        }
        private static int SearchingForRepeatItems(List<int> collection)
            => collection.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).First();
        private static string IO(int repeatElement)
            => repeatElement.Equals(0) ? "0" : String.Join(string.Empty, repeatElement);
    }
}
