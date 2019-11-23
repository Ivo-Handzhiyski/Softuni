using System;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = msg => Console.WriteLine(msg);

            var names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
