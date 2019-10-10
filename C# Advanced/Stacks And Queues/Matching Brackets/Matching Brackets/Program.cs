using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    var leftIndex = stack.Pop();
                    var expressions = input.Substring(leftIndex, i - leftIndex + 1);
                    Console.WriteLine(expressions);
                }
            }
        }
    }
}
