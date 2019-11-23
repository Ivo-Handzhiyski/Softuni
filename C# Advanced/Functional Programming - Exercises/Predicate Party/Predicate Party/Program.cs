using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            Func<string, int, bool> lenghtFunc = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFunc = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> EndsWithFunc = (name, pattern) => name.EndsWith(pattern);


            while (command != "Party!")
            {

                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                string condition = commandArgs[1];
                string param = commandArgs[2];


                if(action == "Remove")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(param);

                        names = names.Where(name => !lenghtFunc(name, length)).ToList();
                        
                    }
                    else if (condition == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, param)).ToList();
                        
                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(name => !EndsWithFunc(name, param)).ToList();
                        
                    }
                }
                else if(action == "Double")
                {
                    if(condition == "Length")
                    {
                        int length = int.Parse(param);

                       var temp =  names.Where(name => lenghtFunc(name, length)).ToList();
                        names.AddRange(temp);
                    }
                    else if(condition == "StartsWith")
                    {
                        var temp = names.Where(name => startsWithFunc(name, param)).ToList();
                        names.AddRange(temp);
                    }
                    else if(condition == "EndsWith")
                    {
                        var temp = names.Where(name => EndsWithFunc(name, param)).ToList();
                        names.AddRange(temp);
                    }
                }
                 command = Console.ReadLine();
            }

            if(names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
