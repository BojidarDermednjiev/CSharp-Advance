namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string inputLine;
            Stack<char> stack;
            bool areBalance;
            GetInfo(out inputLine, out stack, out areBalance);
            areBalance = Engine(inputLine, stack, areBalance);
            IO(areBalance);
        }

        private static void GetInfo(out string inputLine, out Stack<char> stack, out bool areBalance)
        {
            inputLine = Console.ReadLine();
            stack = new Stack<char>();
            areBalance = false;
        }

        private static bool Engine(string inputLine, Stack<char> stack, bool areBalance)
        {
            foreach (char bracket in inputLine)
            {
                if (bracket == '{' || bracket == '(' || bracket == '[')
                    stack.Push(bracket);
                else if (bracket == '}' || bracket == ')' || bracket == ']')
                {
                    if (!stack.Any())
                    {
                        areBalance = false;
                        break;
                    }
                    char lastOpen = stack.Pop();
                    if ((lastOpen == '{' && bracket == '}') || (lastOpen == '[' && bracket == ']') || (lastOpen == '(' && bracket == ')'))
                        areBalance = true;
                    else
                    {
                        areBalance = false;
                        break;
                    }
                }
            }
            return areBalance;
        }

        private static void IO(bool areBalance)
        {
            Console.WriteLine(areBalance ? "YES" : "NO");
        }
    }
}
