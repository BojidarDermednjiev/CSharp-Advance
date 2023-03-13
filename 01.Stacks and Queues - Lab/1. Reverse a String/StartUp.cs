namespace _1._Reverse_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static string inputLineFromConsole;
        static void Main(string[] args)
        {
            Stack<string> stack = GetInfo();
            Console.WriteLine(Engine(stack, 0));
        }
        private static Stack<string> GetInfo()
        {
            inputLineFromConsole = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            return stack;
        }
        private static string Engine(Stack<string> stack, int index)
        {
            if (index >= inputLineFromConsole.Length)
            {
                stack.Reverse();
                return IO(stack);
            }
            stack.Push(inputLineFromConsole[index].ToString());
            return Engine(stack, index + 1);
        }
        private static string IO(Stack<string> stack)
            => String.Join("", stack);
    }
}
