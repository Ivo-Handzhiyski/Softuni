using System;
using System.Linq;
using System.Collections.Generic;

namespace Find_Even_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;

            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int beginning = range[0];
            int ending = range[1];
            string or = Console.ReadLine();
            List<int> leftOvers = new List<int>();
            if(or == "odd")
            {
                List<int> xd = new List<int>();
                for (int i = beginning; i <= ending; i++)
                {
                    xd.Add(i);

                }
                foreach (var number in xd)
                {
                    if(isOdd(number))
                    {
                        leftOvers.Add(number);
                    }
                    
                }
                
            }
           else if (or == "even")
            {
                List<int> xd = new List<int>();
                for (int i = beginning; i <= ending; i++)
                {
                    xd.Add(i);

                }
                foreach (var number in xd)
                {
                    if (isEven(number))
                    {
                        leftOvers.Add(number);
                    }
                }
               
            }
            Console.WriteLine(string.Join(" ",leftOvers));

        }
    }
}
