using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {

            int Operations = int.Parse(Console.ReadLine());

            Stack<string> previousCommand = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < Operations; i++)
            {
                string[] commands = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



                if (commands[0] == "1")
                {
                    previousCommand.Push(text);
                    text += commands[1];
                   

                }
                else if(commands[0] == "2")
                {
                    previousCommand.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(commands[1]));
                }
                else if (commands[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                }
                else if (commands[0] == "4")
                {
                    text = previousCommand.Pop();
                        
                }
            }
        }
    }
}
