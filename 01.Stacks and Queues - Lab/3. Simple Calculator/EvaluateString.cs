using System;
using System.Collections.Generic;
using System.Text;

public class EvaluateString
{

    public static void Main(string[] args)
    {
        Console.WriteLine(EvaluateString.
                     Evaluate(Console.ReadLine()));
    }
    public static int Evaluate(string expression)
    {
        char[] tokens = expression.ToCharArray();
        Stack<int> values = new Stack<int>();
        Stack<char> operation = new Stack<char>();
        for (int currentIndex = 0; currentIndex < tokens.Length; currentIndex++)
        {
            if (tokens[currentIndex] == ' ')
                continue;
            if (tokens[currentIndex] >= '0' && tokens[currentIndex] <= '9')
            {
                StringBuilder sbuf = new StringBuilder();
                while (currentIndex < tokens.Length &&
                        tokens[currentIndex] >= '0' &&
                            tokens[currentIndex] <= '9')
                    sbuf.Append(tokens[currentIndex++]);

                values.Push(int.Parse(sbuf.ToString()));

                currentIndex--;
            }

            else if (tokens[currentIndex] == '+' ||
                     tokens[currentIndex] == '-' ||
                     tokens[currentIndex] == '*' ||
                     tokens[currentIndex] == '/')
            {
                while (operation.Count > 0 &&
                         HasPrecedence(tokens[currentIndex],
                                     operation.Peek()))
                    values.Push(ApplyOperation(operation.Pop(),
                                     values.Pop(),
                                   values.Pop()));
                operation.Push(tokens[currentIndex]);
            }
        }
        while (operation.Count > 0)
            values.Push(ApplyOperation(operation.Pop(),
                             values.Pop(),
                            values.Pop()));
        return values.Pop();
    }
    public static bool HasPrecedence(char firstOperation,
                                     char secondOperation)
    {
        if ((firstOperation == '*' || firstOperation == '/') &&
               (secondOperation == '+' || secondOperation == '-'))
            return false;
        else
            return true;
    }
    public static int ApplyOperation(char operation,
                            int b, int a)
    {
        switch (operation)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;
        }
        return 0;
    }
}