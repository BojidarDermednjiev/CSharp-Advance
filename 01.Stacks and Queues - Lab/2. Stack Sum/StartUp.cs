namespace Training
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Stack<int> stack = GetInfo();
            string command;
            command = Engine(stack);
            Console.WriteLine(IO(stack));
        }
        private static Stack<int> GetInfo()
        {
            return new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray());
        }
        private static string Engine(Stack<int> stack)
        {
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                var splitOperationOfCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (splitOperationOfCommand[0] == "add")
                {
                    stack.Push(int.Parse(splitOperationOfCommand[1]));
                    stack.Push(int.Parse(splitOperationOfCommand[2]));
                }
                else if (splitOperationOfCommand[0] == "remove")
                {
                    int count = int.Parse(splitOperationOfCommand[1]);
                    if (stack.Count >= count)
                        for (int i = 0; i < count; i++)
                            stack.Pop();

                }
            }
            return command;
        }
        private static string IO(Stack<int> stack)
            => $"Sum: {stack.Sum()}";
    }
}