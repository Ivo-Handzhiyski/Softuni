using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(double.Parse).ToList();
            var numbersWithVAT = input.Select(x => x * 1.20);

            foreach (var number in numbersWithVAT)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
