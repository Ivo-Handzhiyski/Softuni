using System;
using System.Linq;

namespace lek12
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];

            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write("{0} ", numbers[j]);

            }
            Console.WriteLine("\n{0}", sum);

        }
    }
}