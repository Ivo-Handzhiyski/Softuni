using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int x = dimestions[0];
            int y = dimestions[1];
            int[,] matrix = new int[x, y];

            int value = 0;
          
            PopulateMatrix(x, y, matrix, value);

            string command = Console.ReadLine();
            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] rowAndColOfIvo = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int EvilPowerCordsX = evil[0];
                int EvilPowerCordsY = evil[1];

                while (EvilPowerCordsX >= 0 && EvilPowerCordsY >= 0)
                {
                    if (EvilPowerCordsX >= 0 && EvilPowerCordsX < matrix.GetLength(0) && EvilPowerCordsY >= 0 && EvilPowerCordsY < matrix.GetLength(1))
                    {
                        matrix[EvilPowerCordsX, EvilPowerCordsY] = 0;
                    }
                    EvilPowerCordsX--;
                    EvilPowerCordsY--;
                }

                int FoundX = rowAndColOfIvo[0];
                int FoundY = rowAndColOfIvo[1];

                while (FoundX >= 0 && FoundY < matrix.GetLength(1))
                {
                    if (FoundX >= 0 && FoundX < matrix.GetLength(0) && FoundY >= 0 && FoundY < matrix.GetLength(1))
                    {
                        sum += matrix[FoundX, FoundY];
                    }

                    FoundY++;
                    FoundX--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static void PopulateMatrix(int x, int y, int[,] matrix, int value)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
