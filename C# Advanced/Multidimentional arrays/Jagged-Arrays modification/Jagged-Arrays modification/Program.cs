using System;
using System.Collections.Generic;
using System.Linq;

namespace Jagged_Arrays_modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var jaggedArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = numbers;
            }

            while (true)
            {
                var command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }

                var parts = command.Split(' ');
                var row = int.Parse(parts[1]);
                var col = int.Parse(parts[2]);
                var num = int.Parse(parts[3]);
                if (row < 0 || row > jaggedArray.Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col < 0 || col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command.StartsWith("Add "))
                {
                    jaggedArray[row][col] += num;

                }
                else if(command.StartsWith("Subtract "))
                {
                    jaggedArray[row][col] -= num;
                }
            }


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
