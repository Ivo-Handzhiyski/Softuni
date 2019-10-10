using System;
using System.IO;
using System.Text;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] xd = File.ReadAllLines("input1.txt");
            string[] readSecond = File.ReadAllLines("input2.txt");

            File.WriteAllText("result.txt", "");
            for (int i = 0; i < xd.Length; i++)
            {
                File.AppendAllText("result.txt", xd[i]);
                File.AppendAllText("result.txt", "\r\n");
                File.AppendAllText("result.txt", readSecond[i]);
                File.AppendAllText("result.txt", "\r\n");

            }

        }
    }
}
