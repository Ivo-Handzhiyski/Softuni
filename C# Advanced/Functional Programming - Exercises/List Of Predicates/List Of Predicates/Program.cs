using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int ending = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            var devidors = Console.ReadLine().Split().Select(int.Parse).ToList();

           

            for (int i = 1; i <= ending; i++)
            {
               if(isDevisible(i, devidors))
                {
                    numbers.Add(i);
                }

            }
            Console.WriteLine(string.Join(" ",numbers));

        }
        

        private static bool isDevisible(int n, List<int> devisior)
        {
            bool isTrue = true;
            foreach (var item in devisior)
            {
                if(n % item != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;

        }
    }
}
