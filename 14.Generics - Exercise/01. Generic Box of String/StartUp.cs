namespace _01._Generic_Box_of_String
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var countOfBoxes = int.Parse(Console.ReadLine());
            for (int currentBox = 0; currentBox < countOfBoxes; currentBox++)
            {
                var inputLineFromConsole = Console.ReadLine();
                Box<string> box = new Box<string>(inputLineFromConsole);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
