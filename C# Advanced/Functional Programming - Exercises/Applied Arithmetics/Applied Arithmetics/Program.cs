using System;
using System.Linq;
using System.Collections.Generic;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int> addNumbers = num => num += 1;
            Func<int, int> multiplyNumbers = num => num *= 2;
            Func<int, int> substracNumbers = num => num -= 1;
            string command = Console.ReadLine();

            while (command != "end")
            {
                if(command == "add")
                {
                   numbers =  numbers.Select(addNumbers).ToArray();
                }
                else if(command == "multiply")
                {
                  numbers =  numbers.Select(multiplyNumbers).ToArray();
                }
                else if(command== "subtract")
                {
                   numbers = numbers.Select(substracNumbers).ToArray();
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }




                command = Console.ReadLine();
            }
        }
    }
}
