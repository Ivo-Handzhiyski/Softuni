using System;
using System.Collections.Generic;

namespace BoxOfT
{
   public class Program
    {
        static void Main(string[] args)
        {


            Box<int> box = new Box<int>();
            box.Add(2);
            Console.WriteLine(box.Count);
        }
    }
}
