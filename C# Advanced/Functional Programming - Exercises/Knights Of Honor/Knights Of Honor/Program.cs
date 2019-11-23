using System;

namespace Knights_Of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = msg => Console.WriteLine("Sir " + msg);

            var names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
