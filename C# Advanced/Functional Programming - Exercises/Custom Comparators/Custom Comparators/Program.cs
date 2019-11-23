using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparators
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
           numbers = numbers.OrderBy(x => x % 2 != 0).ToArray();
            Console.WriteLine(string.Join(" ",numbers));
           // Comparer<int> myCustomComparer = 
            //Array.Sort(numbers, CompareString);
        }

        public static int CompareString(string s1, string s2)
        {


            return 0;
        }
    }
}
