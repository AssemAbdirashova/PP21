using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_button
{
    public partial class Form1 : Form
    {
        int a, b;
        int count;
        bool operation = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
          
        }

        private void Why(int a , int Secondn)
        {

            int del = a / Secondn;

            int why = del * Secondn;
            int why1 = (del + 1) * Secondn;

            if (Math.Abs(a - why) > Math.Abs(a - why1))
            {
                b = why1;
            }
            else
            {
                b = why;
            }
            textBox1.Text = b.ToString();


        }
        private void Comprime(int a, int Secondn)
        {
            int[] first = new int[a / 2];
            int[] second = new int[Secondn / 2];
            for(int i = 1; i< a/2-1; i++)
            {
                if( a % i == 0)
                {
                    first[i] = i;
                }
            }
            for (int i = 1; i < Secondn / 2-1; i++)
            {
                if (Secondn % i == 0)
                {
                    second[i] = i;
                }
            }

            b = 1;
            for(int i =1; i < a/2-1; i++)
            {
                for( int j =1; j < Secondn / 2-1; j++)
                {
                    if(first[i] == second[j] && first[i] !=0 )
                    {
                        b = first[i];
                        break;
                    }
                    else
                    {
                        b = 1;
                    }
                }
            }

            textBox1.Text = b.ToString();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    Why(a, int.Parse(textBox1.Text));
                    break;
                case 2:
                    Comprime(a, int.Parse(textBox1.Text));
                    break;
                case 3:
                default:
                    break;

            }

        }
       
        private void Doit(int i)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            operation = true;
            count = i;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Doit(1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Doit(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operation == true)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (operation == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                operation = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

    }
}
