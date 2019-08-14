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
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(">");
            string result = splittedInput[0];
            int remainingPower = 0;

            for (int i = 1; i < splittedInput.Length; i++)
            {
                result += ">";

                string currentString = splittedInput[i];
                char digitSymbol = currentString[0];
                int power = int.Parse(digitSymbol.ToString()) + remainingPower;

                if (power > currentString.Length)
                {
                    remainingPower = power - currentString.Length;

                }
                else
                {
                    result += currentString.Substring(power);
                }
            }
            Console.WriteLine(result);
        }

    }

}