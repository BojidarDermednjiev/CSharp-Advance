namespace _04._Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
