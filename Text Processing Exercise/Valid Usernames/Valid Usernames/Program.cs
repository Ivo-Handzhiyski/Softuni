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
            List<string> usernames = Console.ReadLine().Split(", ").ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                string currentUsername = usernames[i];
                bool xd = true;
                bool dx = true;
                if (currentUsername.Length < 3 || currentUsername.Length > 16)
                {
                    xd = false;
                }

                for (int j = 0; j < currentUsername.Length; j++)
                {
                    char currentSymbol = currentUsername[j];

                    if (!char.IsLetterOrDigit(currentSymbol) && currentSymbol != '-' && currentSymbol != '_')
                    {
                        dx = false;
                    }
                }

                if (xd == true && dx == true)
                {
                    Console.WriteLine(currentUsername);
                }
            }


        }
    }
}
