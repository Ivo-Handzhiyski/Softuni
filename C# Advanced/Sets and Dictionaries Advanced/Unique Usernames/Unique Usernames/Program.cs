using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var coll = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                coll.Add(input);
            }

            foreach (var name in coll)
            {
                Console.WriteLine(name);
            }

        }
    }
}
