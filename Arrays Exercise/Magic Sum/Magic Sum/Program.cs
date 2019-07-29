using System;
using System.Linq;

namespace lek12
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumbers = numbers[i];


                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNumber = numbers[j];

                    if (firstNumbers + secondNumber == magicNumber)
                    {
                        Console.WriteLine($"{firstNumbers} {secondNumber}");
                    }
                }
            }
        }
    }
}