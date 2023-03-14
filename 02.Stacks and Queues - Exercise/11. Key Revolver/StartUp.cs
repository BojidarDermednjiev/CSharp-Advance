namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int bullet, sizeOfTheGunBarrel, valueOfIntelligence, usedBullets;
            Stack<int> bullets;
            Queue<int> locks;
            GetInfo(out bullet, out sizeOfTheGunBarrel, out bullets, out locks, out valueOfIntelligence, out usedBullets);
            usedBullets = Engine(sizeOfTheGunBarrel, bullets, locks, usedBullets);
            IO(bullet, bullets, locks, valueOfIntelligence, usedBullets);
        }
        private static void GetInfo(out int bullet, out int sizeOfTheGunBarrel, out Stack<int> bullets, out Queue<int> locks, out int valueOfIntelligence, out int usedBullets)
        {
            bullet = int.Parse(Console.ReadLine());
            sizeOfTheGunBarrel = int.Parse(Console.ReadLine());
            bullets = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            locks = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            valueOfIntelligence = int.Parse(Console.ReadLine());
            usedBullets = default;
        }
        private static int Engine(int sizeOfTheGunBarrel, Stack<int> bullets, Queue<int> locks, int usedBullets)
        {
            while (bullets.Any() && locks.Any())
            {
                var currentBulletSize = bullets.Pop();
                usedBullets++;
                if (currentBulletSize > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                if (usedBullets % sizeOfTheGunBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }
            return usedBullets;
        }
        private static void IO(int bullet, Stack<int> bullets, Queue<int> locks, int valueOfIntelligence, int usedBullets)
        {
            Console.WriteLine(locks.Any() ? $"Couldn't get through. Locks left: {locks.Count}" : $"{bullets.Count} bullets left. Earned ${valueOfIntelligence - usedBullets * bullet}");
        }
    }
}
