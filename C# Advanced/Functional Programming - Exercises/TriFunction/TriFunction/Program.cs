using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, int, bool> isEqualOrLargerFunc = (word, criteria) => word.Sum(x => x) >= criteria;

            var inputNames = Console.ReadLine()
                .Split()
                .ToArray();

            Func<string[], Func<string, int, bool>, string> xd = (names, IsLargerFunc) => names.FirstOrDefault(x => IsLargerFunc(x, n));


            string targetName = xd(inputNames, isEqualOrLargerFunc);

            Console.WriteLine(targetName);
        }
    }
}
