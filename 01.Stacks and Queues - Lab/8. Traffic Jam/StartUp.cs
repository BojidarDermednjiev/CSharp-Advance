namespace _8._Traffic_Jam
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int passed, totalPassCar;
            string readCarsFromConsole;
            Queue<string> queue;
            GetInfo(out passed, out queue, out totalPassCar);
            readCarsFromConsole = Engine(passed, queue, ref totalPassCar);
            Console.WriteLine(IO(totalPassCar));
        }

        private static void GetInfo(out int passed, out Queue<string> queue, out int totalPassCar)
        {
            passed = int.Parse(Console.ReadLine());
            queue = new Queue<string>();
            totalPassCar = default;
        }

        private static string Engine(int passed, Queue<string> queue, ref int totalPassCar)
        {
            string readCarsFromConsole;
            while ((readCarsFromConsole = Console.ReadLine()) != "end")
            {
                if (readCarsFromConsole == "green")
                {
                    for (int i = 0; i < passed; i++)
                        if (queue.Count > 0)
                        {
                            PassedCars(queue);
                            totalPassCar++;

                        }
                    continue;
                }
                queue.Enqueue(readCarsFromConsole);
            }
            return readCarsFromConsole;
        }

        private static void PassedCars(Queue<string> queue)
        {
            Console.WriteLine("{0} passed!", queue.Dequeue());
        }

        private static string IO(int totalPassCar)
            => $"{totalPassCar} cars passed the crossroads.";
    }
}
