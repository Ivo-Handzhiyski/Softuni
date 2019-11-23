using System;
using System.Linq;

namespace Predicates_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, bool> filter = name => name.Length <= lenght;
            var leftNames = names.Where(filter);
            foreach (var name in leftNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
