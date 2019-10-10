using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();

            while (input != "END")
            {
                var inputSplit = input.Split(", ");
                if(inputSplit[0] == "IN")
                {
                    parking.Add(inputSplit[1]);

                }
                else
                {
                    parking.Remove(inputSplit[1]);
                }

                input = Console.ReadLine();

            }

            if(parking.Count != 0)
            {
                foreach (var cars in parking)
                {
                    Console.WriteLine(cars);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
