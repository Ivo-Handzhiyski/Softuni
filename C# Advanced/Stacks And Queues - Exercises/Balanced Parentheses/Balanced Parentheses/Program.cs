using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expressions = Console.ReadLine();

            Dictionary<char, char> pairsBracket = new Dictionary<char, char>
            {
                {'{', '}'}, {'[', ']'}, {'(', ')'},
            };

            
            if(expressions.Length % 2 != 0)
            
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> openingBrackets = new Stack<char>();

            for (int i = 0; i < expressions.Length; i++)
            {
                char ch = expressions[i];

                if(ch == '(' || ch == '{' || ch == '[')
                {
                    openingBrackets.Push(ch);

                }
                else if(openingBrackets.Count == 0)
                {
                    Console.WriteLine("NO");
                    break;
                }
                else
                {
                    char lastOpeningBracket = openingBrackets.Pop();
                    char exprectedClosingBracket = pairsBracket[lastOpeningBracket];

                    if(ch != exprectedClosingBracket)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                   
                }

            }
            Console.WriteLine("YES");
        }
    }
}
