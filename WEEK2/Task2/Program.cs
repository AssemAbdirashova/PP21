using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2


{
    class Program
    {
        static void Solve(string s)
        {
            bool ok = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] != s[i])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");


            }
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Дакотти\Desktop\aaa\Test1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadLine();
            Solve(str);

            sr.Close();
            fs.Close();
        }
    }
}