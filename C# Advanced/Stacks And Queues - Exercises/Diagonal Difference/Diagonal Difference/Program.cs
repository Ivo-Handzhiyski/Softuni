using System;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var rows = int.Parse(input[0]);
            var cols = int.Parse(input[1]);
            var matrix = new string[rows, cols];
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var rowElement = rowAsString.Split(" ");


                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElement[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string a = matrix[row, col];
                    if(a == matrix[row + 1,col] && a == matrix[row, col + 1] && a == matrix[row + 1,col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
