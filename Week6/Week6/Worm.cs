using System;                   
using System.Collections.Generic;
using System.Text;

namespace Week6
{
    class Worm:Gameobject
    {
        public void Move(int dx, int dy)
        {
            Clear();

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }
            body[0].X = body[0].X + dx;
            body[0].Y = body[0].Y + dy;

        }
        public bool CheckFW(Worm w, Point p)
        {
            for (int i = 1; i < w.body.Count; i++)
            {
                if (w.body[0].X == w.body[i].X && w.body[0].Y == w.body[i].Y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckCollision(Point p)
        {
            bool res = false;
            if (p.X == body[0].X && p.Y == body[0].Y)
            {
                res = true;
            }
            return res;
        }
        public void Eat(Point p)
        {
            body.Add(new Point { X = p.X, Y = p.Y });
        }
        public Worm(char sign) : base(sign)
        {
            body.Add(new Point { X = 20, Y = 20 });
        }
        /*public bool Gameover(Wall wall)
        {
            for(int i = 0; i < body.Count; i++)
            {
                if(body[0].X == body[i].X && body[0].Y == body[i].Y)
                {
                    return true;
                }
            }
            for (int i = 0; i < wall.body.Count; i++)
            {
                if (body[0].X == wall.body[i].X && body[0].Y == wall.body[i].Y)
                {
                    return true;
                }
            }
            return false;
        }
        */
    }
}

