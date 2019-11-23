using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var xd = Console.ReadLine().Split(", ").Select(Parse);

            Console.WriteLine(xd.Count());
            Console.WriteLine(xd.Sum());
        }

        static int Parse(string str)
        {
            int number = 0;

            foreach (var ch in str)
            {
                number *= 10;
                number += ch - '0';
            }

            return number;
        }
    }
}
