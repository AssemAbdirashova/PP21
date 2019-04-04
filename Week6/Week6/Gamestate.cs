using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
    class Gamestate
    {
        public Worm w = new Worm('O');
        public Food f = new Food('@');
        public Wall b = new Wall('#');

        public Gamestate()
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
        }
        public void Draw()
        {
            w.Draw();
            f.Draw();
            b.Draw();
        }
        
        void CheckFood()
        {
            if (w.CheckCollision(f.body[0]))
            {
                w.Eat(f.body[0]);
                
                f.Foodinrandomposition(b, w);
            }
        }
        public bool Gameover()
        {
            /*for (int i = 1; i < w.body.Count; i++)
            {
                if (w.body[0].X == w.body[i].X && w.body[0].Y == w.body[i].Y)
                {
                    return true;
                }
            }*/
            for (int i = 0; i < b.body.Count; i++)
            {
                if (w.body[0].X == b.body[i].X && w.body[0].Y == b.body[i].Y)
                {
                    return true;
                }
            }
            return false;
        }
        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    w.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    w.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    w.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    w.Move(1, 0);
                    break;
            }
           
            CheckFood();
           }
        

    }

    
}
