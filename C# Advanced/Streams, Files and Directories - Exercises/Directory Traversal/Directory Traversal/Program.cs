using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] fileArray = Directory.GetFiles(".", "*.*");

            var dictoryInfo = new Dictionary<string, Dictionary<string, double>>();

            var directoryInformation = new DirectoryInfo(".");

            FileInfo[] allFiles = directoryInformation.GetFiles();

            foreach (var file in allFiles)
            {
                double size = file.Length / 1024d;
                string fileName = file.Name;
                string extension = file.Extension;

                if(!dictoryInfo.ContainsKey(extension))
                {
                    dictoryInfo.Add(extension, new Dictionary<string, double>());

                }
                if(!dictoryInfo[extension].ContainsKey(fileName))
                {
                    dictoryInfo[extension].Add(fileName, size);

                }
            }

            var sortedDic = dictoryInfo.OrderByDescending(x =>x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach (var (extension , value) in sortedDic)
            {

                File.AppendAllText(path, extension + Environment.NewLine);

                

                foreach (var (FileName,size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path,$"--{FileName} - {size:f3}kb" + Environment.NewLine);
                }
            }
        }
    }
}
