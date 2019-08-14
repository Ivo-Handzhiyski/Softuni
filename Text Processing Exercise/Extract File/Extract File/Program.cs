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
            string[] strings = Console.ReadLine().Split(@"\");

            int lmao = strings.Length - 1;
            string xd = strings[lmao];

            string[] NameAndExt = xd.Split('.');

            string fileName = NameAndExt[0];
            string extansion = NameAndExt[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extansion}");
        }
        
    }

}
