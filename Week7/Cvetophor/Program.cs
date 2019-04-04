using System;
using System.Threading;

namespace Cvetophor
{
    class Program
    {
        static int cur = 0;
        static Wall wall;
        static void Main(string[] args)
        {
            wall = new Wall();
            for (int x = 21; x <= 31; ++x)
            {
                if (x == 24 || x == 28)
                    continue;
                for (int y = 20; y <= 23; ++y)
                {
                    Point p = new Point(y, x);
                    wall.addPoint(p);
                }
            }

            ThreadStart threadStart = new ThreadStart(move);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Console.SetWindowSize(40, 40);
            while (true)
            {
                if (cur == 0 && wall.)
                {


                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else {    
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (cur == 1)
                {


                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                else {        
                            Console.ForegroundColor = ConsoleColor.Black;
                        
                    
                }
                if (cur == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
            }
        }

        public static void move()
        {
            while (true)
            {
                wall.draw();
                cur = cur + 1;
                if (cur >= 3)
                {
                    cur = 0;
                }
                Thread.Sleep(1000);
            }
        }
    }
}