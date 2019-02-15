using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Done(int n)
        {
            Console.Write(n + " ");
            Console.Write(n);
            Console.Write(" ");
        }
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            int n = int.Parse(line1);
            string[] parts = line2.Split();//(new char[] { ' ', ',', '$' });
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(parts[i]);
                Done(k);

            }
            Console.ReadKey();
        }

    }
}
