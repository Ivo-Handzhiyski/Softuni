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
            var regex = @">>(?<item>.+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            double totalPrice = 0;
            List<string> xd = new List<string>();
            var furniture = Console.ReadLine();


            while (furniture != "Purchase")
            {
                Match boughtFurniture = Regex.Match(furniture, regex);
                if (boughtFurniture.Success)
                {
                    string mebel = boughtFurniture.Groups["item"].Value;
                    double price = double.Parse(boughtFurniture.Groups["price"].Value);
                    double quantity = double.Parse(boughtFurniture.Groups["quantity"].Value);

                    xd.Add(mebel);

                    totalPrice += price * quantity;
                }



                furniture = Console.ReadLine();

            }


            Console.WriteLine("Bought furniture:");
            foreach (var item in xd)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total money spend: {0:f2}", totalPrice);


        }

    }
}