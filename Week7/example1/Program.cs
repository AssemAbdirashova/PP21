using System;
using System.Threading;

namespace example1
{
    class Program
    {
        public static Object obj = new Object();

        static void Main(string[] args)
        {
            Thread[] th = new Thread[4];
            th[0] = new Thread(Line1);
            th[0].Start();
            th[1] = new Thread(Line2);
            th[1].Start();
            th[2] = new Thread(Line3);
            th[2].Start();
            th[3] = new Thread(Line4);
            th[3].Start();
        }
        public static void Line1()
        {
            lock (obj)
            {
                for(int i = 1; i < 20; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(i,1);
                    Console.Write("ass");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

        }
        public static void Line2()
        {
            lock (obj)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(20,i);
                    Console.Write("ass");
                    Thread.Sleep(100);
                    Console.Clear();

                }
            }
        }
        public static void Line3()
        {
            lock (obj)
            {
                for (int i = 20 ; i > 1; i--)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(i, 1);
                    Console.Write("ass");
                    Thread.Sleep(100);
                    Console.Clear();

                }
            }

        }
        public static void Line4()
        {
            lock (obj)
            {
                for (int i = 10; i > 1; i--)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(1, 10);
                    Console.Write("ass");
                    Thread.Sleep(100);
                    Console.Clear();

                }
            }

        }
    }
}
