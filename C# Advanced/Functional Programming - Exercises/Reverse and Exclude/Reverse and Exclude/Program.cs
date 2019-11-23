using System;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int divisor = int.Parse(Console.ReadLine());

            Func<int, bool> predicate = n => n % divisor != 0;

            var remainingNums = numbers.Reverse().Where(predicate);
            Console.WriteLine(string.Join(" ",remainingNums));
        }
    }
}
