using System;
using System.IO;
using System.Text;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var consoleOutput = new StreamWriter("console-output.txt");
            Console.SetOut(consoleOutput);
            using (var reader = new StreamReader($"xd.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter % 2 == 1)
                    {
                        
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
            consoleOutput.Close();
        }
    }
}
