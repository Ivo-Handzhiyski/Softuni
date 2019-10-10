using System;
using System.IO;
using System.Text;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in a)
            {
                FileInfo fi = new FileInfo(file);
                sum += fi.Length;
            }

            sum = sum / 1024 / 1024;

            using (StreamWriter xd = new StreamWriter("output1.txt"))
            {
                xd.WriteLine(sum);
            }
            

        }
    }
}
