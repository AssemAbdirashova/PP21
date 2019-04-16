using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt2

{
    public partial class Form1 : Form
    {
        Brain brain;
        public Form1()
        {
            InitializeComponent();
            brain = new Brain(new DisplayTextDelegate(DisplayText));
        }
        void DisplayText(string msg)
        {
            textBox1.Text = msg;
        }
        void ButtonPressed(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            brain.Process(bt.Text);

        }

       
    }
    public delegate void DisplayTextDelegate(string text);
}
