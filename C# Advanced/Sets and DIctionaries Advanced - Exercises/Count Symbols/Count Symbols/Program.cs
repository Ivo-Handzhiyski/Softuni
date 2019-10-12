using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var occurances = new SortedDictionary<char, int>();


            for (int i = 0; i < input.Length; i++)
            {
                if(!occurances.ContainsKey(input[i]))
                {
                    occurances.Add(input[i], 1);

                }
                else
                {
                    occurances[input[i]]++;
                }
            }

            foreach (var item in occurances)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
