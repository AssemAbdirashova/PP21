using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Week6
{
    class Wall : Gameobject
    {
        enum GameLevel
        {
            FIRST,
            SECOND,
            THIRD
        }

        GameLevel gameLevel = GameLevel.FIRST;

        public Wall(char sign) : base(sign)
        {
            LoadLevel();
        }
        public void NextLevel()
        {
            if (gameLevel == GameLevel.FIRST)
                gameLevel = GameLevel.SECOND;
            else if (gameLevel == GameLevel.SECOND)
                gameLevel = GameLevel.THIRD;
            LoadLevel();
        }
        public void LoadLevel()
        {
            string fileName = "level1.txt";
            if (gameLevel == GameLevel.SECOND)
                fileName = "level2.txt";
            if (gameLevel == GameLevel.THIRD)
                fileName = "level3.txt";



            FileStream fs = new FileStream(@"C:\Users\Дакотти\Desktop\snake.txt", FileMode.Open, FileAccess.Read);
            //string name = string.Format("C:\Users\Дакотти\Desktop\snake.TXT");
            StreamReader sr = new StreamReader(fs);
            //string text = sr.ReadLine();
            int r = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (int c = 0; c < line.Length; ++c)
                {
                    if (line[c] == '#')
                    {
                        body.Add(new Point { X = c, Y = r });
                    }
                }
                r++;
            }

            sr.Close();
            fs.Close();
        }
        /*public bool CheckCollision1(Point p)
        {
            bool res = false;
            for (int i = 0; i < body.Count; i++)
            {
                if (p.X == body[i].X && p.Y == body[i].Y)
                {
                    res = true;
                }
            }
            return res;
        }*/
    }
}
