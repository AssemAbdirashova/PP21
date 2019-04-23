using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Graphics graphics;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);

            int x = 0;
            int y = 0;
            int height = 20;
            int width = 20;
            e.Graphics.DrawEllipse(pen, x, y, width, height);
            e.Graphics.FillEllipse(pen.Brush, x, y, width, height);
        }
    }
}
