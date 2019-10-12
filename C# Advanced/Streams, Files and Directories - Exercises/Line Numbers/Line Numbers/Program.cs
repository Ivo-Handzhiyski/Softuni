using System;
using System.IO;
using System.Linq;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string outputPath = "output.txt";
            string[] textLines = File.ReadAllLines(textPath);

            int lineCounter = 1;


            foreach (var currentLine in textLines)
            {
                int lettersCount = currentLine.Count(char.IsLetter);
                int symbolsCOunt = currentLine.Count(char.IsPunctuation);

               File.AppendAllText(outputPath,$"Line {lineCounter}: {currentLine} ({lettersCount})({symbolsCOunt}){Environment.NewLine}");
                lineCounter++;
               
            }
        }
    }
}
