using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimenstions = Console.ReadLine().Split();
            int rows = int.Parse(dimenstions[0]);
            int cols = int.Parse(dimenstions[1]);

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var rowElement = rowAsString.Split(" ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElement[col];
                }
            }

            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "END")
            {
                if (command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else if(command[0] == "swap" && command.Length == 5)
                {
                    int rowA = int.Parse(command[1]);
                    int colA = int.Parse(command[2]);
                    int rowB = int.Parse(command[3]);
                    int colB = int.Parse(command[4]);


                    if (rowA >= 0 && rowA <= rows - 1 && colA >= 0 && colA <= cols - 1
                       && rowB >= 0 && rowB <= rows - 1 && colB >= 0 && colB <= cols - 1)
                    {
                        var temp = matrix[rowA, colA];
                        matrix[rowA, colA] = matrix[rowB, colB];
                        matrix[rowB, colB] = temp;


                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }



                }
                
                command = Console.ReadLine().Split();
            }
            
        }


    }
}
    

