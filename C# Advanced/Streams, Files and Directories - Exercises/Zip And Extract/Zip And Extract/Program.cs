using System;
using System.IO.Compression;
using System.IO;

namespace Zip_And_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var zipFile = @"..\..\..\myNewzip.zip";
            var file = "copyMe.png";



            using (var archive  = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                
                    archive.CreateEntryFromFile(file, Path.GetFileName(file));
                
                

            }
        }

    }
}
