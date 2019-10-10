using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;




            Queue<int> q = new Queue<int>(orders);

            int bigNumber = q.Max();
            Console.WriteLine(bigNumber);
            while (q.Count > 0)
            {


                int pop = q.Peek();
                sum += pop;
                if(sum <= quantityOfFood)
                {
                    q.Dequeue();
                }
                else
                {
                    int[] arr = q.ToArray();
                    Console.WriteLine("Orders left: " + string.Join(" ",arr));
                    return;
                } 
                
                   


            }
            Console.WriteLine("Orders complete");
        }
    }
}
