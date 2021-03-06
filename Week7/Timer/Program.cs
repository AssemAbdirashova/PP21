﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += DoIt;
            timer.Start();

            //Thread.CurrentThread.Join();

            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                Console.Write(consoleKeyInfo.Key);
            }
        }

        private static void DoIt(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hi!");
        }
    }
}
