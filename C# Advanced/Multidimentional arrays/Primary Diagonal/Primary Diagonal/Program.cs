using System;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            
                
            for (int i = 0; i < n; i++)
            {
                char[] array = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = array[j];

                }
                
                
            }
            string symbol = Console.ReadLine();
            bool xd = false;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].ToString() == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        xd = true;
                        break;
                        
                    }
                    
            
                }
            }
            if(xd == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
