namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;

    public class StartUp
    {

        private static Func<int[], int[]> add = arr => arr.Select(x => ++x).ToArray();
        private static Func<int[], int[]> subtract = arr => arr.Select(x => --x).ToArray();
        private static Func<int[], int[]> multiply = arr => arr.Select(x => x * 2).ToArray();
        private static Func<int[], int[]> decrease = arr => arr.Select(x => x / 2).ToArray();
        private static Action<int[]> print = arr => Console.WriteLine(String.Join(" ", arr));
        static void Main()
        {
            int[] nums = GetInfo();
            ConsoleOperation(Console.ReadLine(), nums);
        }
        private static int[] GetInfo()
            => Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        static void ConsoleOperation(string input, int[] nums)
        {
            switch (input)
            {
                case "add":
                    nums = add(nums); 
                    break;
                case "subtract": 
                    nums = subtract(nums); 
                    break;
                case "multiply": 
                    nums = multiply(nums);
                    break;
                case "decrease":
                    nums = decrease(nums);
                    break;
                case "print":
                    print(nums);
                    break;
                case "end":
                    return;
            }
            ConsoleOperation(Console.ReadLine(), nums);
        }
    }
}
