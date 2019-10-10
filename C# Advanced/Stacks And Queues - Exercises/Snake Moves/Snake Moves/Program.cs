using System;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var rows = int.Parse(input[0]);

            var cols = int.Parse(input[1]);

            var matrix = new char[rows, cols];

            var snake = Console.ReadLine();

            int counter = 0;

            for (int row = 0; row < rows; row++)
            {


                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {

                        matrix[row, col] = snake[counter++];

                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                    
                }
                else
                {
                    for (int col = cols - 1; col >=  0; col--)
                    {

                        matrix[row, col] = snake[counter++];

                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }



            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
