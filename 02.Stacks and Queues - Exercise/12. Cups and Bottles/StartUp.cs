namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Queue<int> cupsCapacity;
            Stack<int> bottels;
            int sumWastedWater, watedWater;
            GetInfo(out cupsCapacity, out bottels, out sumWastedWater, out watedWater);
            Engine(cupsCapacity, bottels, ref sumWastedWater, ref watedWater);
            IO(cupsCapacity, bottels, sumWastedWater);
        }

        private static void GetInfo(out Queue<int> cupsCapacity, out Stack<int> bottels, out int sumWastedWater, out int watedWater)
        {
            cupsCapacity = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            bottels = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            sumWastedWater = default;
            watedWater = default;
        }
        private static void Engine(Queue<int> cupsCapacity, Stack<int> bottels, ref int sumWastedWater, ref int watedWater)
        {
            while (cupsCapacity.Any() && bottels.Any())
            {
                int currentCup = cupsCapacity.Peek();
                if (watedWater < 0)
                    currentCup = watedWater;
                watedWater = bottels.Pop() - Math.Abs(currentCup);
                if (watedWater >= 0)
                {
                    sumWastedWater += watedWater;
                    cupsCapacity.Dequeue();
                    watedWater = default;
                }
            }
        }
        private static void IO(Queue<int> cupsCapacity, Stack<int> bottels, int sumWastedWater)
        {
            if (cupsCapacity.Any())
                Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
            else if (bottels.Any())
                Console.WriteLine($"Bottles: {string.Join(" ", bottels)}");

            Console.WriteLine($"Wasted litters of water: {sumWastedWater}");
        }
    }
}
