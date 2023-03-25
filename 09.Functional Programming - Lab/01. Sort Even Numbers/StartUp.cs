namespace _01._Sort_Even_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split(", ").Select(x => int.Parse(x)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray()));
        }
    }
}
