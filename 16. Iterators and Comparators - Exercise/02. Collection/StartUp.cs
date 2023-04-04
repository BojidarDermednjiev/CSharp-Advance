namespace _02._Collection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var entries = Console.ReadLine().Split().Skip(1).ToArray();
            ListyIterator<string> listy = new ListyIterator<string>(entries);
            ListyIteratorOperation(Console.ReadLine(), listy);
        }

        private static string ListyIteratorOperation(string inputLineFromConsole, ListyIterator<string> listy)
        {
            if (inputLineFromConsole == "END")
                return listy.ToString();
            switch (inputLineFromConsole)
            {
                case "Move": Console.WriteLine(listy.Move()); break;
                case "HasNext": Console.WriteLine(listy.HasNext()); break;
                case "Print": listy.Print(); break;
                case "PrintAll": listy.PrintAll(); break;
            }
            return ListyIteratorOperation(Console.ReadLine(), listy);
        }
    }
}
