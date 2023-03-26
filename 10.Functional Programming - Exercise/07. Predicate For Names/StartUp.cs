namespace _07._Predicate_For_Names
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int maxLength = int.Parse(Console.ReadLine());
            Predicate<string> isValidLength = x => x.Length <= maxLength;
            IO(isValidLength);
        }
        private static void IO(Predicate<string> isValidLength)
        {
            Console.WriteLine(String.Join(Environment.NewLine, Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => isValidLength(x))));
        }
    }
}
