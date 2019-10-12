using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] wordsLines = File.ReadAllLines(wordsPath);

            var Wordsinfo = new Dictionary<string, int>();

            foreach (var word in wordsLines)
            {
                string currentWordLower = word.ToLower();
                if(!Wordsinfo.ContainsKey(currentWordLower))
                {

                    Wordsinfo.Add(currentWordLower, 0);

                }
            }
            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] { ' ', '-', ',', '?', '!', '.','\'',':',';' });

                foreach (var words in currentLineWords)
                {
                    if(Wordsinfo.ContainsKey(words))
                    {
                        Wordsinfo[words]++;
                    }
                }
            }

            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";

            foreach (var (key,value) in Wordsinfo)
            {
                File.AppendAllText(actualResultPath,$"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in Wordsinfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
            

        }
    }
}
