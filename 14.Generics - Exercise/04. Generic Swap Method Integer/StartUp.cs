namespace _04._Generic_Swap_Method_Integer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            var dataForAccidence = new List<string>();
            var numberOfInputs = int.Parse(Console.ReadLine());
            for (int currentInput = 0; currentInput < numberOfInputs; currentInput++)
                dataForAccidence.Add(Console.ReadLine());
            var indexForSwap = Console.ReadLine();
            var first = indexForSwap.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).First();
            var second = indexForSwap.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Last();
            dataForAccidence = Swap(dataForAccidence, first, second);
            dataForAccidence.ForEach(x => Console.WriteLine(x));
        }
        private static List<T> Swap<T>(List<T> dataForAccidence, int first, int second)
        {
            (dataForAccidence[first], dataForAccidence[second]) = (dataForAccidence[second], dataForAccidence[first]);
            return dataForAccidence;
        }
    }
}
