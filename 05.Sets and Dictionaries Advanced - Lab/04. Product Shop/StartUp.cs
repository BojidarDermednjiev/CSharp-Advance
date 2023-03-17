namespace _04._Product_Shop
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        private static SortedDictionary<string, Dictionary<string, double>> productShop;
        static void Main()
        {
            Engine();
            IO();
        }
        private static void Engine()
        {
            productShop = new SortedDictionary<string, Dictionary<string, double>>();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Revision")
            {
                string theMarket = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                string theProduct = inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
                double thePrice = double.Parse(inputLine.Split(", ", StringSplitOptions.RemoveEmptyEntries)[2]);
                if (!productShop.ContainsKey(theMarket))
                    productShop.Add(theMarket, new Dictionary<string, double>());
                productShop[theMarket][theProduct] = thePrice;
            }
        }
        private static void IO()
        {
            foreach (var shop in productShop)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}
