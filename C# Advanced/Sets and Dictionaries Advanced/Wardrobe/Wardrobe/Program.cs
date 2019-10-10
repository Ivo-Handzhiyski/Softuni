using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrope = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                var clothes = input[1].Split(',');

                if(!wardrope.ContainsKey(color))
                {
                    wardrope.Add(color, new Dictionary<string, int>());
                }
                foreach (var clothing in clothes)
                {
                    if(!wardrope[color].ContainsKey(clothing))
                    {
                        wardrope[color].Add(clothing, 0);

                    }

                    wardrope[color][clothing]++;
                }

            }

            var InputTargerItem = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string targetColor = InputTargerItem[0];
            string targetItem = InputTargerItem[1];

            foreach (var clothes in wardrope)
            {
                Console.WriteLine($"{clothes.Key} clothes:");

                foreach (var item in clothes.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if(item.Key == targetItem && clothes.Key == targetColor)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
