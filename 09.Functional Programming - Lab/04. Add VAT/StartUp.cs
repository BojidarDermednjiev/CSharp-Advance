namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Func<string, string> addVat = x => (decimal.Parse(x) * 1.20M).ToString("F2");
            Action<string> print = numberFromInputLine => Console.WriteLine(numberFromInputLine);
            print(string.Join(Environment.NewLine, Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(addVat)));
        }
    }
}
