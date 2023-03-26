namespace _02._Knights_of_Honor
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
            Action<string[]> print = x => Console.WriteLine(Environment.NewLine, "Sir " + x);
            print(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());
        }
    }
}
