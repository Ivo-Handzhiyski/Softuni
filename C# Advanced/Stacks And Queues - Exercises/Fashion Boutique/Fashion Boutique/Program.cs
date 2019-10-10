using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int racks = 1;
            Stack<int> stack = new Stack<int>(integers);

            while (stack.Count > 0)
            {
                int xd = stack.Peek();
                sum += xd;
                if(sum == capacity)
                {
                    racks++;
                    stack.Pop();
                    sum = 0;
                }
                else if(sum > capacity)
                {
                    racks++;
                    sum = 0;
                }
                else if(sum < capacity)
                {
                    stack.Pop();

                }
               
               

            }
           
            Console.WriteLine(racks);
           

          

        }
    }
}
