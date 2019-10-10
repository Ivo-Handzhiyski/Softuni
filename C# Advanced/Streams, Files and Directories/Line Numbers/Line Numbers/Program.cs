using System;
using System.IO;
using System.Text;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader($"TextFile1.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {

                    var numbers = 1;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        line = $"{numbers}.  {line}";

                        writer.WriteLine(line);
                        numbers++;
                    }
                }
            }


        }
    }
}
