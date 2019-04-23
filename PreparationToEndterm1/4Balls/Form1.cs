using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Balls
{
    public partial class Form1 : Form
    {
        int x = 100;
        int y = 100;
        int r = 30;
        Bitmap bitmap;
        Graphics g;
        bool mouseClicked = false;
        SolidBrush brush = new SolidBrush(Color.Blue);
        public Form1()
        {      
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            g.FillEllipse(brush, x, y, r, r);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(brush, x, y, r, r);
        }
        bool again = false;
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            again = true;
            Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (again)
            {
                y = y + 15;
                g.FillEllipse(brush, x, y, r, r);
                Refresh();
                g.Clear(Color.White);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
