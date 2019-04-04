using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Week6

{
    class Food : Gameobject
    {
        public Food(char sign) : base(sign)
        {
            body.Add(new Point { X = 20, Y = 18 });
            //Generate();

        }
        /*public void Generate()
        {
            Random random = new Random(DateTime.Now.Second);
            body.Clear();
            body.Add(new Point
            {
                X = random.Next(1, 39),
                Y = random.Next(1, 39)
            });
        }*/
        public void Foodinrandomposition(Wall wall, Worm worm)
        {
            Random random = new Random(DateTime.Now.Second);

            int q = random.Next(1, 39);
            int p = random.Next(1, 39);
            while (Checking(wall, worm, q, p))
            {
                q = random.Next(1, 39);
                p = random.Next(1, 39);
            }
            body.Clear();
            body.Add(new Point
            {
                X = random.Next(1, 39),
                Y = random.Next(1, 39)
            });
        }
        public bool Checking(Wall wall, Worm worm, int x, int y)
        {
            for (int i = 0; i < wall.body.Count; i++)
            {
                for (int j = 0; j < worm.body.Count; j++)
                {
                    if ((wall.body[i].X == x && wall.body[i].Y == y) || (worm.body[j].X == x && worm.body[j].Y == y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}