namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Stack<int> stack;
            int capacityOfARack, sumOfClothes, numberOfRack;
            GetInfo(out stack, out capacityOfARack, out sumOfClothes, out numberOfRack);
            Engine(stack, capacityOfARack, ref sumOfClothes, ref numberOfRack);
            IO(numberOfRack);
        }
        private static void GetInfo(out Stack<int> stack, out int capacityOfARack, out int sumOfClothes, out int numberOfRack)
        {
            stack = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            capacityOfARack = int.Parse(Console.ReadLine());
            sumOfClothes = default;
            numberOfRack = 1;
        }
        private static void Engine(Stack<int> stack, int capacityOfARack, ref int sumOfClothes, ref int numberOfRack)
        {
            while (stack.Count > 0)
            {
                sumOfClothes += stack.Peek();
                if (sumOfClothes <= capacityOfARack)
                {
                    if (!stack.Any())
                        break;
                    stack.Pop();
                    continue;
                }
                else
                {
                    numberOfRack++;
                    sumOfClothes = default;
                }
            }
        }
        private static void IO(int numberOfRack)
        {
            Console.WriteLine(numberOfRack);
        }
    }
}
