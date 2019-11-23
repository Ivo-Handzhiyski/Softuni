using System;
using System.Linq;


namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            var capitalsWords = input.Where(word => char.IsUpper(word[0]));

            foreach (var word in capitalsWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
