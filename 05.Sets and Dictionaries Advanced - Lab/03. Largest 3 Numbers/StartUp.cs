namespace _03._Largest_3_Numbers
{
    using System;
    using System.Linq;
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IO();
        }

        private static void IO()
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).OrderByDescending(number => number).Take(3).ToList()));
        }
    }
}
