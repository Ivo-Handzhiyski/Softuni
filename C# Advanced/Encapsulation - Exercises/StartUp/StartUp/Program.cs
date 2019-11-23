using System;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double lenght = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(height,lenght,width);

            Console.WriteLine(box.ToString());
        }
    }
}
