namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StartUp
    {
        static void Main()
        {
            int countOfOperation;
            StringBuilder text;
            Stack<string> textHistory;
            GetInfo(out countOfOperation, out text, out textHistory);
            Engine(countOfOperation, text, textHistory);
        }
        private static void GetInfo(out int countOfOperation, out StringBuilder text, out Stack<string> textHistory)
        {
            countOfOperation = int.Parse(Console.ReadLine());
            text = new StringBuilder();
            textHistory = new Stack<string>();
        }
        private static void Engine(int countOfOperation, StringBuilder text, Stack<string> textHistory)
        {
            for (int currentOperation = 0; currentOperation < countOfOperation; currentOperation++)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("1"))
                {
                    textHistory.Push(text.ToString());
                    text.Append(command.Split()[1]);
                }
                else if (command.StartsWith("2"))
                {
                    textHistory.Push(text.ToString());
                    text.Remove(text.Length - int.Parse(command.Split()[1]), int.Parse(command.Split()[1]));
                }
                else if (command.StartsWith("3"))
                    ReturnTheElementOfTheLastPossion(text, command);
                else if (command.StartsWith("4"))
                    text = new StringBuilder(textHistory.Pop());
            }
        }
        private static void ReturnTheElementOfTheLastPossion(StringBuilder text, string command)
        {
            Console.WriteLine(text[int.Parse(command.Split()[1]) - 1]);
        }
    }
}
