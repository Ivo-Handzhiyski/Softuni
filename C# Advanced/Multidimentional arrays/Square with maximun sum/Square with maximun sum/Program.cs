using System;

namespace Square_with_maximun_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(", ");
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var rowElement = rowAsString.Split(", ");


                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElement[col]);
                }
            }

            int subMatrixOfCols = 2;
            int subMatrixOfRows = 2;

            int maxSumOf2x2 = int.MinValue;

            int MaxSumOf2x2Row = -1;
            int MaxSumOf2x2Col = -1;

            

            for (int row = 0; row < matrix.GetLength(0) - subMatrixOfRows + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixOfCols + 1; col++)
                {
                    var subMatrixSum = 0;
                    for (int sumRow = 0; sumRow < subMatrixOfRows; sumRow++)
                    {
                        for (int sumCol = 0; sumCol < subMatrixOfCols; sumCol++)
                        {
                            subMatrixSum += matrix[row + sumRow, col + sumCol];

                        }
                    }

                    if(subMatrixSum > maxSumOf2x2)
                    {
                        maxSumOf2x2 = subMatrixSum;
                        MaxSumOf2x2Row = row;
                        MaxSumOf2x2Col = col;
                    }
                }
            }
            
            
            for (int row = 0; row < subMatrixOfRows; row++)
            {
                for (int col = 0; col < subMatrixOfCols; col++)
                {
                    Console.Write(matrix[MaxSumOf2x2Row + row,MaxSumOf2x2Col + col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSumOf2x2);
        }
    }
}
