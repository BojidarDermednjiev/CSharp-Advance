﻿namespace _03._Stack
{
    using System;
    using System.Linq;
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Push")
                {
                    string[] elements = command.Skip(1).ToArray();
                    stack.Push(elements);
                }
                else if (command[0] == "Pop")
                    stack.Pop();
            }
            foreach (var item in stack)
                Console.WriteLine(item);
            foreach (var item in stack)
                Console.WriteLine(item);
        }
    }
}
