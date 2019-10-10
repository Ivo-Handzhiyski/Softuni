using System;
using System.IO;
using System.Text;

namespace Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 4;
            var totalSize = new FileInfo("TextFile1.txt").Length;
            var sizePerFile = (int)Math.Ceiling(totalSize / 4.0);

            using (FileStream sr = new FileStream("TextFile1.txt",FileMode.Open))
            {
                for (long i = 1; i <= n; i++)
                {
                    var buffer = new byte[sizePerFile];
                   var xd = sr.Read(buffer, 0, sizePerFile);
                    using (FileStream w = new FileStream($"file-{i}.txt", FileMode.OpenOrCreate))
                    {
                        w.Write(buffer, 0, xd);


                    }

                }
            }
            

        }
    }
}
