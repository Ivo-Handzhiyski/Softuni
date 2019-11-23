using System;
using System.Linq;

namespace Custom_Min_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minValue = number => number.Min();

            Console.WriteLine(minValue(numbers));

        }
    }
}
