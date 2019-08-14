using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$"; ;

            string input = Console.ReadLine();

            double totalPrice = 0;

            while (input != "end of shift")
            {
                Match xd = Regex.Match(input, regex);
                if (xd.Success)
                {
                    string name = xd.Groups["customer"].Value;
                    string product = xd.Groups["product"].Value;
                    int count = int.Parse(xd.Groups["count"].Value);
                    double price = double.Parse(xd.Groups["price"].Value);

                    double xdPrice = count * price;

                    Console.WriteLine($"{name}: {product} - {xdPrice:f2}");
                    totalPrice += xdPrice;
                }




                input = Console.ReadLine();

            }
            Console.WriteLine("Total income: {0:f2}", totalPrice);

        }

    }
}