using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircleAround1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 20;
            Console.SetCursorPosition(x, y);
            while (x != 40)
            {
                x++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
                Thread.Sleep(100);
                Console.Clear();

            }
            if (x == 40)
            {
                while (y != 40)
                {
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            if (y == 40)
            {
                while (x != 20)
                {
                    x--;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            if (x == 20)
            {
                while (y != 20)
                {
                    y--;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
    }
}
/*
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading; 

namespace traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Red);
            th1.Start();
            Thread.Sleep(400);
            Thread th2 = new Thread(Yellow);
            th2.Start();
            Thread.Sleep(400);
            Thread th3 = new Thread(Green);
            th3.Start();
            Thread.Sleep(400);
        }
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green; ;
        }
        /*Console.CursorVisible = false; 
        Console.SetCursorPosition(0, 1); 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("Stop"); 
        Console.WriteLine("*"); 
        Thread.Sleep(1000); 
        Console.Clear(); 
        Console.SetCursorPosition(0, 2); 
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine("Get Ready"); 
        Console.WriteLine("*"); 
        Thread.Sleep(1000); 
        Console.Clear(); 
        Console.SetCursorPosition(0, 3); 
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("Run"); 
        Console.WriteLine("*"); 
        Console.ReadKey();
    }
}
*/