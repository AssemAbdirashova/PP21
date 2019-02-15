using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {
        public static bool Prime(int num) // create method to determine prime
        {
            bool ok = false;
            if (num == 1)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < num; i++) // consider all the divisors of the number
                {
                    if (num % i == 0) // divide and determine
                    {
                        ok = true;
                        break;
                    }

                }
            }
            return ok;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Дакотти\Desktop\aaa\Test2.txt", FileMode.Open, FileAccess.Read);
            StreamReader str = new StreamReader(fs);


            string line = str.ReadLine();
            string[] parts = line.Split();
            int[] res = new int[parts.Length];
            for (int i = 0; i < parts.Length; ++i)
            {
                res[i] = int.Parse(parts[i]);

            }
            /*string line = str.ReadLine();
            string[] nums=  line.Split(' ');
            
            foreach(var x in nums)
            {
                if (Prime(nums))
                {
                    res.Add(x);
                }
            }*/



            FileStream fs2 = new FileStream(@"C:\Users\Дакотти\Desktop\aaa\Test3.txt", FileMode.Create, FileAccess.Write);
            StreamWriter str2 = new StreamWriter(fs2);
            for (int i = 0; i < res.Length; i++)
            {
                if (Prime(res[i]) == false)
                {
                    str2.Write(res[i] + " ");
                    //Console.Write(res[i] + " ");

                }
            }
            str2.Close();
            fs2.Close();



        }
    }
}