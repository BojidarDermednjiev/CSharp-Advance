namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            var petrol = new Queue<int>();
            var distance = new Queue<int>();
            int[] input;
            for (int currentPetrolPump = 0; currentPetrolPump < petrolPumps; currentPetrolPump++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }
            int currentFuel;
            for (int fuel = 0; fuel < petrolPumps; fuel++)
            {
                currentFuel = petrol.Peek();
                for (int currentStation = 0; currentStation < petrolPumps; currentStation++)
                {
                    if (distance.Peek() <= currentFuel)
                    {
                        currentFuel -= distance.Peek();
                        if (currentStation == petrolPumps - 1)
                        {
                            Console.WriteLine(fuel);
                            return;
                        }
                    }
                    else
                    {
                        for (int nextStation = currentStation; nextStation < petrolPumps; nextStation++)
                        {
                            petrol.Enqueue(petrol.Dequeue());
                            distance.Enqueue(distance.Dequeue());
                        }
                        break;
                    }
                    petrol.Enqueue(petrol.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                    currentFuel += petrol.Peek();
                }
                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
            }
        }
    }
}
