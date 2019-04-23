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

namespace Parabolic
{
    public partial class Form1 : Form
    {
        int a = 100;
        int b = 100;
      
        int r = 30;
        bool IsVisible = true;
        bool again = false;

        SolidBrush brush = new SolidBrush(Color.Green);

        GraphicsPath gp = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            gp.AddEllipse(new Rectangle(a, b, 2 * r, 2 * r));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (again == true)
            {
                b = b + 20;
                gp.Reset();
                gp.AddEllipse(new Rectangle(a, b, 2 * r, 2 * r));
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            IsVisible = false;
            Refresh();  
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gp.IsVisible(e.Location))
            {
                IsVisible = true;

                again = true;
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(brush, gp);
        }
    }
}
