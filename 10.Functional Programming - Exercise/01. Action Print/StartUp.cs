namespace _01._Action_Print
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
            Action<string[]> print = x => Console.WriteLine(String.Join(Environment.NewLine, x));
            print(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());
        }
    }
}
