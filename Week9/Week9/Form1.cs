using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r = 10;
        Point p0 = new Point(250, 120);
        Point p1 = new Point(350, 140);
        Pen pen = new Pen(Color.Red);
        Pen pen2 = new Pen(Color.Green);
        int w = 50;
        int h = 50;

        Color[] color = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        int index = 0;
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(pen, p0.X - r, p0.Y - r, w + 3 * r, h + 3 * r);
            e.Graphics.FillEllipse(pen.Brush, p0.X - r, p0.Y - r, w + 3 * r, h + 3 * r);
            e.Graphics.FillEllipse(pen2.Brush, p1.X - r, p1.Y - r, w + 3 * r, h + 3 * r);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % color.Length;
            pen2 = new Pen(color[index]);

            Random random = new Random();
            pen = new Pen(Color.FromArgb(random.Next()));
            r += 5;
            Refresh();

            
        }

        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green);
            e.Graphics.DrawLine(pen, 0, 0, 100, 100);

            SolidBrush solidBrush = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(solidBrush, 120, 120, 200, 200);

            e.Graphics.FillEllipse(pen.Brush, 120, 120, 200, 200);

        }*/


    }
}
