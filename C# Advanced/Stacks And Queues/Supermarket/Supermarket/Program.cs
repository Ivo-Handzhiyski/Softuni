using System;
using System.Collections.Generic;
namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var q = new Queue<string>();
            int countPeople = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }
                else if(command == "Paid")
                {
                    int count = q.Count;
                    for (int i = 0; i < count; i++)
                    {
                        
                       string xd = q.Dequeue();
                        Console.WriteLine(xd);
                        countPeople--;
                    }
                }
                else
                {
                    q.Enqueue(command);
                    countPeople++;
                    
                }
            }
            Console.WriteLine(countPeople + " people remaining.");
        }
    }
}
