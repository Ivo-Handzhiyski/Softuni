using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var times = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!times.ContainsKey(number))
                {
                    times.Add(number, 1);

                }
                else
                {
                    times[number]++;
                }
            }
            foreach (var time in times)
            {
                if(time.Value % 2 == 0)
                {
                    var answer = time.Key;
                    Console.WriteLine(answer);
                }
            }
        }
    }
}
