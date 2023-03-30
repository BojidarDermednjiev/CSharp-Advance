namespace _09._Custom_Linked_List
{
    using CustomDoublyLinkedList;
    using System;
    public class StartUp
    {
        static void Main()
        {
            DoublyLinkedList<int> intList = new DoublyLinkedList<int>();

            for (int currentNumber = 1; currentNumber <= 5; currentNumber++)
            {
                intList.AddFirst(currentNumber);
            }

            for (int currentNumber = 6; currentNumber <= 11; currentNumber++)
            {
                intList.AddLast(currentNumber);
            }

            intList.ForEach(x => Console.WriteLine(x + " "));

            Console.WriteLine("----------");

            for (int currentNumber = 1; currentNumber <= 10; currentNumber++)
            {
                Console.WriteLine(intList.RemoveFirst());
            }

            Console.WriteLine("----------");

            DoublyLinkedList<string> stringList = new DoublyLinkedList<string>();

            for (int currenNumber = 0; currenNumber < 3; currenNumber++)
            {
                stringList.AddFirst($"Gosho {currenNumber + 2}");
            }

            for (int currentNumber = 0; currentNumber < 3; currentNumber++)
            {
                stringList.AddLast($"Pesho {currentNumber + 1}");
            }

            stringList.ForEach(x => Console.WriteLine(x + " "));

            Console.WriteLine("----------");

            Console.WriteLine(string.Join('|', stringList.ToArray()));

            Console.WriteLine("----------");

            for (int currentNumber = 0; currentNumber < 6; currentNumber++)
            {
                Console.WriteLine(stringList.RemoveFirst());
            }
        }
    }
}
