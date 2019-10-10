using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            var firstN = new HashSet<int>();
            var firstM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstN.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstM.Add(number);
            }

            Console.WriteLine(string.Join(" ",firstN.Intersect(firstM)));
        }
    }
}
