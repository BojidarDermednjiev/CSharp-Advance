namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Predicate<string> checkForWordWithUpperCase = word => char.IsUpper(word[0]);
            Action<string> print = word => Console.WriteLine(word);
            print(string.Join(Environment.NewLine, Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(currentWord => checkForWordWithUpperCase(currentWord))));
        }
    }
}


