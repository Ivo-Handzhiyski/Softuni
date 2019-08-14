using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.","Such a great product.","I always use that product.","Best product of its category."
                ,"Exceptional product.","I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded in life.", "Makes miracles. I am happy with the result!",
                "I cannot believe but now i feel awesome.", "Try it yourself, I am very satisfied.", "I feel great." };

            string[] Authours = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = { "Burgas", "Sofia", "Varna", "Ruse" };

            int count = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {

                string phrase = phrases[random.Next(0, phrases.Length)];
                string @event = events[random.Next(0, events.Length)];
                string Authour = Authours[random.Next(0, Authours.Length)];
                string Citie = Cities[random.Next(0, Cities.Length)];
                Console.WriteLine($"{phrase} {@event} {Authour} - {Citie}.");
            }
        }
    }

}