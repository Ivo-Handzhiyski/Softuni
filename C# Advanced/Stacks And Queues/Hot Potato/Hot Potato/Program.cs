using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();

            var q = new Queue<string>(names);
            int potato = int.Parse(Console.ReadLine());

            

            while (q.Count > 1)
            {
                for (int i = 1; i < potato; i++)
                {
                    q.Enqueue(q.Dequeue());
                }

                Console.WriteLine($"Removed {q.Dequeue()}");
            }
            Console.WriteLine($"Last is {q.Dequeue()}");
        }
    }
}
