using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> symbols = new Stack<char>(input);

            while(symbols.Count > 0)
            {
                char ch = symbols.Pop();
                Console.Write(ch);
            }

        }
    }
}
