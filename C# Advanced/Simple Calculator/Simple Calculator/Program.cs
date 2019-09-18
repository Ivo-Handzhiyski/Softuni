using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(GetInt);
            var stack = new Stack<int>(numbers);


            while (true)
            {
                var command = Console.ReadLine().ToLower();
                var parts = command.Split(" ");
                var commandName = parts[0];

                if (commandName.StartsWith("add"))
                {

                    stack.Push(int.Parse(parts[1]));
                    stack.Push(int.Parse(parts[2]));
                }
                else if (commandName.StartsWith("remove"))
                {

                    var ItemsToRemove = int.Parse(parts[1]);
                    for (int i = 0; i < ItemsToRemove; i++)
                    {
                        stack.Pop();
                    }

                }
                else if (commandName.StartsWith("end"))
                {
                    break;
                }
            }
            var result = stack.Sum();
            Console.WriteLine(result);


        }

        static int GetInt(string a)
        {
            return int.Parse(a);
        }
    }
}