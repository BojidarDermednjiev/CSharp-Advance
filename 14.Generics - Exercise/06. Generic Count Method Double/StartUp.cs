namespace _06._Generic_Count_Method_Double
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            var boxes = new List<Box<string>>();
            var numberOfEntries = int.Parse(Console.ReadLine());
            for (int currentEntry = 0; currentEntry < numberOfEntries; currentEntry++)
                boxes.Add(new Box<string>(Console.ReadLine()));
            var item = Console.ReadLine();
            Console.WriteLine(Box<string>.GetCountLargerElements(boxes, item)); ;
        }
    }
}
