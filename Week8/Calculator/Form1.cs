using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double a, b;
        int count;
        bool operation = true;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
    
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }
        bool ee = false;
        bool ef = false;
        private void button24_Click(object sender, EventArgs e)
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
        private void Doit(int i)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = i;
            operation = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doit(1);
            label1.Text = a.ToString() + "/";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Doit(2);
            label1.Text = a.ToString() + "*";
         }
        private void button13_Click(object sender, EventArgs e)
        {
            Doit(3);
            label1.Text = a.ToString() + "-";
            ef = true;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Doit(4);
            label1.Text = a.ToString() + "+";
            ee = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Doit(5);
            label1.Text = "sqrt" + a.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Doit(6);
            label1.Text = a.ToString() + "^2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doit(7);
            label1.Text = "1/" + a.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;    //Например в текстбоксе записано число 504523
            string text = textBox1.Text;          //При нажатии данной кнопки в переменную лэндз записывается число 5 (6цифр-1)
            textBox1.Clear();                     //ТекстБокс очищается     
            for (int i = 0; i < length; i++)        //Затем по одному записываются символы из текст, но не 6, а 5
            {
                textBox1.Text = textBox1.Text + text[i];     //50452
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doit(8);
            label1.Text = "%" + a.ToString();

        }
        private void Percent(object sender, EventArgs e)
        {
            b = a + a*(double.Parse(textBox1.Text) /100);
            textBox1.Text = b.ToString();
        }

        private void Calculate()
        {
            switch (count)
            {

                case 1:
                    b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = a * a;
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = 1 / a;
                    textBox1.Text = b.ToString();
                    break;
                
                case 9:
                default:
                    break;
            }
        }
    }
}
