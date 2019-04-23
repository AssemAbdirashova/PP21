using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainBody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen1 = new Pen(Color.Red);
        Pen pen2 = new Pen(Color.Yellow);
        Pen pen3 = new Pen(Color.LightGreen);


        private void Asteroids(int x, int y, PaintEventArgs e)
        {

            Point point1 = new Point(x, y + 17);
            Point point2 = new Point(x + 20, y - 17);
            Point point3 = new Point(x - 20, y - 17);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            e.Graphics.FillPolygon(pen1.Brush, curvePoints);
            int y1 = y - 12;
            Point point4 = new Point(x, y1 - 17);
            Point point5 = new Point(x + 20, y1 + 17);
            Point point6 = new Point(x - 20, y1 + 17);
            Point[] curvePoints1 =
             {
                 point4,
                 point5,
                 point6,
             };
            e.Graphics.FillPolygon(pen1.Brush, curvePoints1);
        }




        private void Bullet(int x, int y, PaintEventArgs e)
        {
            int y1 = y + 5;
            int y2 = y - 5;
            int x1 = x + 5;
            int x2 = x - 5;

            Point point1 = new Point(x, y1 + 10);
            Point point2 = new Point(x + 5, y1 );
            Point point3 = new Point(x - 5, y1 );
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints);
            e.Graphics.FillRectangle(pen3.Brush, x - 5, y2, 10, 10);
            Point point4 = new Point(x, y2 - 10);
            Point point5 = new Point(x + 5, y2);
            Point point6 = new Point(x - 5, y2);
            Point[] curvePoints1 =
             {
                 point4,
                 point5,
                 point6,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints1);

            Point point7 = new Point(x1 + 10 , y );
            Point point8 = new Point(x1 ,y + 5);
            Point point9 = new Point(x1, y - 5);
            Point[] curvePoints2 =
             {
                 point7,
                 point8,
                 point9,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints2);
            Point point10 = new Point(x2 - 10, y);
            Point point11 = new Point(x2, y + 5);
            Point point12 = new Point(x2, y - 5);
            Point[] curvePoints3 =
             {
                 point10,
                 point11,
                 point12,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints3);
        }







        private void SpaceShip(int x, int y, PaintEventArgs e)
        {

            Point point1 = new Point(x, y + 10);
            Point point2 = new Point(x + 50, y - 15);
            Point point3 = new Point(x - 50, y - 15);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            e.Graphics.FillPolygon(pen2.Brush, curvePoints);
            int width = 100;
            int height = 40;
            e.Graphics.FillRectangle(pen2.Brush, x - 50, y - 55, width, height);
            int y1 = y - 70;
            Point point4 = new Point(x, y1 - 10);
            Point point5 = new Point(x + 50, y1 + 15);
            Point point6 = new Point(x - 50, y1 + 15);
            Point[] curvePoints1 =
             {
                 point4,
                 point5,
                 point6,
             };
            e.Graphics.FillPolygon(pen2.Brush, curvePoints1);
            Point point7 = new Point(x, y1 + 15);
            Point point8 = new Point(x + 13, y1 + 35);
            Point point9 = new Point(x - 13, y1 + 35);
            Point[] curvePoints2 =
             {
                 point7,
                 point8,
                 point9,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints2);
            e.Graphics.FillRectangle(pen3.Brush, x - 7, y1 + 35, 14, 18);
        }
      
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.White);
            Pen pen0 = new Pen(Color.DarkBlue);
            graphics.FillRectangle(pen0.Brush, 0, 0, this.Width, this.Height);

            e.Graphics.FillEllipse(pen.Brush, 30, 40, 25, 25 );
            e.Graphics.FillEllipse(pen.Brush, 240, 35, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 470, 100, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 700, 120, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 20, 330, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 240, 300, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 600, 220, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 700, 370, 25, 25);


            Asteroids(120, 120, e);
            Asteroids(200, 250, e);
            Asteroids(550, 350, e);
            Asteroids(650, 100, e);

            SpaceShip(400, 250, e);
            Bullet(440, 150, e);
          

        }
    }
}
