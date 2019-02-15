using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Task4

    {
        static void Main()
        {
            // string path = @"C:\Users\Дакотти\Desktop\aaa\example1.txt";
            //File.Create(path);
            FileStream fs = new FileStream(@"C:\Users\Дакотти\Desktop\aaa\achieved.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("The very first line!");

            sw.Close();
            fs.Close();
            string fileName = "achieved.txt";
            string sourcePath = @"C:\Users\Дакотти\Desktop\aaa";
            string path1 = @"C:\Users\Дакотти\Desktop\bbb\western girl";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(path1, fileName);
            File.Copy(sourceFile, destFile, true);
            File.Delete(@"C:\Users\Дакотти\Desktop\aaa\achieved.txt");

        }
    }


}