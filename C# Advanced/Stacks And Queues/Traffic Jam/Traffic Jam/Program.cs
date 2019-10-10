using System;
using System.Collections.Generic;
using System.Linq;
namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCar = int.Parse(Console.ReadLine());
            var q = new Queue<string>();
            int count = 0;
            while (true)
            {
                var command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }
                else if(command == "green")
                {
                    for (int i = 0; i < maxCar; i++)
                    {
                        if(q.Count > 0)
                        {
                            var car = q.Dequeue();
                            Console.WriteLine(car + " passed!");
                            count++;
                        }
                       
                    }
                }
                else
                {
                    q.Enqueue(command);
                }
            }
            Console.WriteLine(count + " cars passed the crossroads.");

        }
    }
}
