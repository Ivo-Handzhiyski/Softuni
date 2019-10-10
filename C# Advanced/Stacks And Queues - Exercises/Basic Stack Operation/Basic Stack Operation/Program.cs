using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Stack_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arg = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersOfElementsToPush = arg[0];
            int numbersOfElementsToPop = arg[1];
            int ifContains = arg[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < numbersOfElementsToPush; i++)
            {
                stack.Enqueue(numbers[i]);


            }

            for (int i = 0; i < numbersOfElementsToPop; i++)
            {
                stack.Dequeue();
            }

            bool contains = stack.Contains(ifContains);

            if(contains)
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
            else
            {

               
                int minValue = int.MaxValue;
                foreach (var item in stack)
                {
                    if(item < minValue)
                    {
                        minValue = item;
                    }
                }
                Console.WriteLine(minValue);
            }
            
        }
    }
}
