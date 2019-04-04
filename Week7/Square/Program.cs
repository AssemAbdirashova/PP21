using System;
using System.Threading;

namespace Square
{
    class Program
    {
        
            static bool right = false;
            static bool left = true;
            static bool down = false;
            static bool up = false;
            static int x = 20;
            static int y = 20;
            static void Main(string[] args)
            {
                ThreadStart threadStart = new ThreadStart(DoIt);
                Thread thread = new Thread(threadStart);
                thread.Start();
                Console.SetWindowSize(40, 40);
                while (true)
                {
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                    if (consoleKeyInfo.Key == ConsoleKey.UpArrow && down == false)
                    {
                        up = true;
                        down = false;
                        left = false;
                        right = false;

                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.DownArrow && up == false)
                    {
                        up = false;
                        down = true;
                        left = false;
                        right = false;

                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                    {
                        up = false;
                        down = false;
                        left = false;
                        right = true;

                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        up = false;
                        down = false;
                        left = true;
                        right = false;

                    }

                }
            }
            public static void Check(int x, int y)
            {
                if (x > 20 && x < 30 && y > 30)
                {
                    y = 20;
                }
                if (y > 20 && x > 30 && y < 30)
                {
                    x = 20;
                }
                if (x < 20 && y > 20 && y < 30)
                {
                    x = 30;
                }
                if (y < 20 && x > 20 && x < 30)
                {
                    y = 20;
                }

            }
            public static void DoIt()
            {
                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    if (up)
                    {
                        y--;
                        Check(x, y);
                    }
                    if (down)
                    {
                        y++;
                        Check(x, y);

                    }
                    if (right)

                    {
                        x++;
                        Check(x, y);

                    }
                    if (left)
                    {
                        x--;
                        Check(x, y);

                    }
                    Thread.Sleep(100);
                }
            }

        }
    }
}
  
