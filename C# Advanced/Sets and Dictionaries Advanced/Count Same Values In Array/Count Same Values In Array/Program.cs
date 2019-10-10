using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse);
            var doubles = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if(!doubles.ContainsKey(number))
                {
                    doubles.Add(number, 0);

                }

                doubles[number]++;
                
            }

            foreach (var KVP in doubles)
            {
                Console.WriteLine($"{KVP.Key} - {KVP.Value} times");
            }    

        }
    }
}
