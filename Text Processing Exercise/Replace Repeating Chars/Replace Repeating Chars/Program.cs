using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord = word[0].ToString();

            foreach (char item in word)
            {
                if (newWord[newWord.Length - 1] != item)
                    newWord += item;
            }
            Console.WriteLine(newWord);
        }

    }

}
