using System;
using System.IO;
using System.Text;
using System.Linq;
namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"../../../text.txt";

            using (StreamReader sr = new StreamReader(textFilePath))            
            {
                int counter = 0;
                string currentLine = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                   
                    if (counter % 2 == 0)
                    {
                       
                        string replacingGeneralSymbols = ReplaceSymbols(currentLine);
                        string reversedwords = ReverseWords(replacingGeneralSymbols);
                        Console.WriteLine(reversedwords);
                    }
                    currentLine = sr.ReadLine();
                    
                    counter++;

                }
                
            }
        }

        private static string ReverseWords(string replacingGeneralSymbols)
        {
            return string.Join(" ", replacingGeneralSymbols.Split().Reverse().ToArray());
            

        }

        private static string ReplaceSymbols(string currentLine)
        {
           return currentLine.Replace("-", "@").
            Replace(",", "@").
            Replace(".", "@").
            Replace("!", "@").
            Replace("-", "@");

        }
    }
}
