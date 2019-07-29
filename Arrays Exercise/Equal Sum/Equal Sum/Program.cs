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

            int leftSum = 0;
            int RightSum = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                RightSum -= numbers[i];

                if (leftSum == RightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numbers[i];
            }
            Console.WriteLine("no");
        }
    }
}
