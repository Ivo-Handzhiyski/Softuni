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
            string normalVersion = Console.ReadLine();

            List<char> changedVersion = new List<char>();
            for (int i = 0; i < normalVersion.Length; i++)
            {
                int changedString = normalVersion[i] + 3;

                char xd = (char)changedString;

                changedVersion.Add(xd);
            }
            foreach (var item in changedVersion)
            {
                Console.Write(item);
            }






        }

    }

}
