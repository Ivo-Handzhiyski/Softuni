using System;
using System.IO;

namespace Copy_Binary_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copy-copied-path.png";

            using (FileStream fs = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream sr = new FileStream(picCopyPath,FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        var size = fs.Read(byteArray, 0, byteArray.Length);
                        sr.Write(byteArray, 0, byteArray.Length);

                        if(size ==0)
                        {
                            break;
                        }
                    }
                    

                }
            }
        }
    }
}
