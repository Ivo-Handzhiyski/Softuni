using System;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(", ");
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);         
            var matrix = new int[rows, cols];
            int[] sumOfCols = new int[cols];

            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var rowElements = rowAsString.Split(" ");

                for (int col = 0; col < cols; col++)
                {
                   
                    matrix[row, col] = int.Parse(rowElements[col]);
                    sumOfCols[cols] = matrix[row, col];
                }

            }

        }
    }
}
