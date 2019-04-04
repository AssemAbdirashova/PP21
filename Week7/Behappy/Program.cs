using System;
using System.Collections.Generic;
using System.Threading;

namespace Behappy
{

    public class Point
    {
        public int x;
        public int y;
        public Point(int x,int y){
            this.x = x;
            this.y = y;
        }
    }
    public class Wall
    {
        protected char sign;
        List<Point> points;
        public Wall()
        {
            points = new List<Point>();
        }

        public void addPoint(Point p)
        {
            points.Add(p);
        }
        public void draw()
        {
            foreach (Point p in points)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write('.');
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wall wall;

            {
                wall = new Wall();
                for (int x = 21; x <= 31; ++x)
                {
                    for (int y = 20; y <= 23; ++y)
                    {
                        Point p = new Point(y, x);
                        wall.addPoint(p);
                    }
                }
            }
            wall.draw();
            Console.SetWindowSize(15, 15);
            Console.SetCursorPosition(21, 24);

            while (true)
            {

                ThreadStart threadStart = new ThreadStart(Move);
                Thread thread = new Thread(threadStart);
                thread.Start();
                ConsoleKeyInfo asd = Console.ReadKey();
                if (asd.Key == ConsoleKey.Spacebar)
                {

                }
            }
        }
        static void Clear()
        {
            Console.SetCursorPosition(p.x, p.y);
            Console.Write(".");
        }
        static void Move()
        {
            ConsoleKeyInfo asd = Console.ReadKey();
            if (asd.Key == ConsoleKey.Spacebar)
            {
                Clear()
                Console.Write("$");
            }
        }
    }
}
