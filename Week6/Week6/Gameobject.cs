﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Week6 { 

    class Gameobject
    {
        public int f=0;
        public List<Point> body = new List<Point>();
        protected char sign;
   
        public Gameobject(char sign)
        {
            this.sign = sign;
        }
    

        public void Clear()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(' ');
            }
        }

        public void Draw()
        {
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(sign);
            }
        }
    }
}
