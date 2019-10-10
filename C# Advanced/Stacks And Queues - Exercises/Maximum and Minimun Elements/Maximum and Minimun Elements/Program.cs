using System;
using System.Collections.Generic;
using System.Linq;
namespace Maximum_and_Minimun_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();


            int quariesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < quariesCount; i++)
            {
                int[] commandElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int commandIndex = commandElements[0];

                switch (commandIndex)
                {
                    case 1:
                        int elementToAdd = commandElements[1];
                        stack.Push(elementToAdd);


                        break;
                    case 2:
                        if(stack.Count > 0)
                        {
                            stack.Pop();
                        }
                       
                        break;
                    case 3:
                        if(stack.Count > 0)
                        Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if(stack.Count > 0)
                        Console.WriteLine(stack.Min());
                        break;

                }
            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
