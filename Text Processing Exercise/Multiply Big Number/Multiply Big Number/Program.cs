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
            string numberAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            int lmao = 0;
            StringBuilder builder = new StringBuilder();
            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(numberAsString[i].ToString());

                int result = lastDigit * multiplier + lmao;
                builder.Append(result % 10);
                lmao = result / 10;



            }

            if (lmao != 0)
            {
                builder.Append(lmao);
            }

            string resultNumber = string.Join("", builder.ToString().Reverse()).TrimStart('0');

            if (resultNumber == string.Empty)
            {
                Console.WriteLine("0");
            }
            else

                Console.WriteLine(resultNumber);

        }

    }

}