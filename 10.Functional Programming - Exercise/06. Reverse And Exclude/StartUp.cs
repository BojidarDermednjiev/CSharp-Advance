namespace _06._Reverse_And_Exclude
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Func<int[], int, int[]> filter;
            Action<int[]> print;
            GetInfo(out filter, out print);
            IO(filter, print);
        }
        private static void GetInfo(out Func<int[], int, int[]> filter, out Action<int[]> print)
        {
            Func<int, int, bool> isNotDivisble = (number, divider) => number % divider != 0;
            filter = (elements, divider) => elements.Where(x => isNotDivisble(x, divider)).Reverse().ToArray();
            print = elements => Console.WriteLine(String.Join(" ", elements));
        }
        private static void IO(Func<int[], int, int[]> filter, Action<int[]> print)
        {
            print(filter(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray(), int.Parse(Console.ReadLine())));
        }
    }
}
