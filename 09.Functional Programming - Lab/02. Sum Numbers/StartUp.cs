namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Action<int[]> print = text => Console.WriteLine(text.Count() + Environment.NewLine + text.Sum());
            print(Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray());
        }
    }
}
