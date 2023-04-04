namespace _07._Custom_Comparator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                             .Split()
                             .Select(x => int.Parse(x))
                             .ToArray();
            NumComparer comparer = new NumComparer();
            Array.Sort(inputArray, comparer);
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
