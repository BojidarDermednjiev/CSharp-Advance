namespace GenericScale
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var left = int.Parse(Console.ReadLine());
            var right = int.Parse(Console.ReadLine());
            EqualityScale<int> equalityScale = new EqualityScale<int>(left, right);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
