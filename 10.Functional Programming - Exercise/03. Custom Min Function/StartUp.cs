namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            IO();
        }
        private static void IO()
        {
            Action<int> print = x => Console.WriteLine(x);
            Func<int[], int> calcMin = x => x.Min();
            print(calcMin(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray()));
        }
    }
}
