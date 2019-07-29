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

            int[] savedArr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstnumber = numbers[i];
                bool isTopInt = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int otherNumber = numbers[j];

                    if (firstnumber <= otherNumber)
                    {
                        isTopInt = false;
                        break;
                    }

                }
                if (isTopInt)
                {
                    Console.Write(firstnumber + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);

        }
    }
}
