namespace _11._TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int threshold;
            List<string> names;
            GetInfo(out threshold, out names);
            Func<string, int, bool> isValidName;
            Func<List<string>, Func<string, int, bool>, string> findName;
            Action<string> print;
            Engine(threshold, out isValidName, out findName, out print);
            IO(isValidName, names, findName, print);
        }
        private static void GetInfo(out int threshold, out List<string> names)
        {
            threshold = int.Parse(Console.ReadLine());
            names = Console.ReadLine().Split().ToList();
        }
        private static void Engine(int threshold, out Func<string, int, bool> isValidName, out Func<List<string>, Func<string, int, bool>, string> findName, out Action<string> print)
        {
            isValidName = (name, limit) => name.ToCharArray().Select(x => (int)x).Sum() >= limit;
            findName = (names, isValidName) => names.Find(x => isValidName(x, threshold));
            print = names => Console.WriteLine(names);
        }
        private static void IO(Func<string, int, bool> isValidName, List<string> names, Func<List<string>, Func<string, int, bool>, string> findName, Action<string> print)
        {
            print(findName(names, isValidName));
        }
    }
}
