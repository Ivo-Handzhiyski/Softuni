using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var periodic = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    periodic.Add(input[j]);
                }

            }

            
            Console.WriteLine(string.Join(" ",periodic.OrderBy(x => x)));
        }
    }
}
