namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> wardrobe;
            int countOfAddintClothesInWardrobe;
            GetInfo(out wardrobe, out countOfAddintClothesInWardrobe);
            FillWardrobe(wardrobe, countOfAddintClothesInWardrobe);
            IO(wardrobe);
        }
        private static void GetInfo(out Dictionary<string, Dictionary<string, int>> wardrobe, out int countOfAddintClothesInWardrobe)
        {
            wardrobe = new Dictionary<string, Dictionary<string, int>>();
            countOfAddintClothesInWardrobe = int.Parse(Console.ReadLine());
        }
        private static void FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int countOfAddintClothesInWardrobe)
        {
            for (int currentColor = 0; currentColor < countOfAddintClothesInWardrobe; currentColor++)
            {
                var inputLineFromConsole = Console.ReadLine().Split(new[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var color = inputLineFromConsole.First();
                if (!wardrobe.ContainsKey(color))
                    wardrobe.Add(color, new Dictionary<string, int>());
                foreach (var cloth in inputLineFromConsole.Skip(1))
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                        wardrobe[color].Add(cloth, 0);
                    wardrobe[color][cloth]++;
                }
            }
        }
        private static void IO(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            var foundCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var colorToFind = foundCloth.First();
            var clothToFind = foundCloth.Last();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                    Console.WriteLine(colorToFind == color.Key && clothToFind == cloth.Key ? $"* {cloth.Key} - {cloth.Value} (found!)" : $"* {cloth.Key} - {cloth.Value}");
            }
        }
    }
}
