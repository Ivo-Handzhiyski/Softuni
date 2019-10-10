using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                var input = Console.ReadLine();
                var split = input.Split(", ");
                var name = split[0];

                if(name == "Revision")
                {
                    break;
                }
                var productName = split[1];
                var price = double.Parse(split[2]);

                if(!shops.ContainsKey(name))
                {
                    shops.Add(name, new Dictionary<string, double>());

                }                           
                    shops[name][productName] = price;
            }


            foreach (var shop in shops)
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
