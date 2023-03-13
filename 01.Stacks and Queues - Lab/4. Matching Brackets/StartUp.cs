namespace _4._Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string inputLineFromConsole;
            Stack<int> stack;
            GetInfo(out inputLineFromConsole, out stack);
            Engine(inputLineFromConsole, stack);
        }
        private static void GetInfo(out string inputLineFromConsole, out Stack<int> stack)
        {
            inputLineFromConsole = Console.ReadLine();
            stack = new Stack<int>();
        }
        private static void Engine(string inputLineFromConsole, Stack<int> stack)
        {
            for (int currentElement = 0; currentElement < inputLineFromConsole.Length; currentElement++)
            {
                char element = inputLineFromConsole[currentElement];
                if (element == '(')
                    stack.Push(currentElement);
                else if (element == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = currentElement;
                    string substring = inputLineFromConsole.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(IO(substring));
                }
            }
        }
        private static string IO(string substring)
            => substring;
    }
}
