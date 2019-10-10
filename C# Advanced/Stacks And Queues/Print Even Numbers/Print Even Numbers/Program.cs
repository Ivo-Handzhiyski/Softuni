using System;
using System.Collections.Generic;
using System.Linq; 

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split();
            var q = new Queue<int>();
            for (int i = 0; i < number.Length; i++)
            {
                if(int.Parse(number[i]) % 2 == 0)
                {
                    q.Enqueue(int.Parse(number[i]));
                }
                

            }
           
            Console.WriteLine(string.Join(", ",q));
        }
        
    }
}
