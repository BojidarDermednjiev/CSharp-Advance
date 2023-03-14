namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int greenLightInSecond, freeWindowInSecond;
            Queue<string> carsToPass;
            Stack<string> passedCar;
            bool hasCrash = default;
            GetInfo(out greenLightInSecond, out freeWindowInSecond, out carsToPass, out passedCar);
            hasCrash = Engine(greenLightInSecond, freeWindowInSecond, carsToPass, passedCar, hasCrash);
            IO(passedCar, hasCrash);
        }
        private static void GetInfo(out int greenLightInSecond, out int freeWindowInSecond, out Queue<string> carsToPass, out Stack<string> passedCar)
        {
            greenLightInSecond = int.Parse(Console.ReadLine());
            freeWindowInSecond = int.Parse(Console.ReadLine());
            carsToPass = new Queue<string>();
            passedCar = new Stack<string>();
        }
        private static bool Engine(int greenLightInSecond, int freeWindowInSecond, Queue<string> carsToPass, Stack<string> passedCar, bool hasCrash)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int greenLight = greenLightInSecond;
                    int freePass = freeWindowInSecond;
                    int counter = carsToPass.Count;
                    for (int currentLigth = 0; currentLigth < counter; currentLigth++)
                    {
                        if (greenLight >= carsToPass.Peek().Length && carsToPass.Any())
                        {
                            greenLight -= carsToPass.Peek().Length;
                            passedCar.Push(carsToPass.Dequeue());
                        }
                        else if (greenLight < carsToPass.Peek().Length && carsToPass.Any())
                        {
                            int timeLeft = greenLight + freePass;
                            if (greenLight <= 0)
                                continue;
                            else if (timeLeft > 0 && timeLeft >= carsToPass.Peek().Length)
                            {
                                string car = carsToPass.Peek();
                                timeLeft -= car.Length;
                                passedCar.Push(carsToPass.Dequeue());
                                greenLight = default;
                                freePass = default;
                            }
                            else if (timeLeft > 0 && timeLeft < carsToPass.Peek().Length)
                            {
                                string car = carsToPass.Peek();
                                Console.WriteLine("A crash happened!");
                                int hit = timeLeft;
                                Console.WriteLine($"{car} was hit at {car[hit]}.");
                                hasCrash = true;
                                return hasCrash;
                            }
                        }
                    }
                }
                else
                    carsToPass.Enqueue(command);
            }
            return hasCrash;
        }
        private static void IO(Stack<string> passedCar, bool hasCrash)
        {
            Console.WriteLine(hasCrash ? String.Empty : "Everyone is safe." + Environment.NewLine + $"{passedCar.Count} total cars passed the crossroads.");
        }
    }
}
