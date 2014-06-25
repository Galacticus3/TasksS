using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool mnozh = false;
        bool dilen = false;
                
        public Form1()
        {
            InitializeComponent();
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

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0"; 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        // sqrt
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            } else
            { return; }
        }

        // + -
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text)) * (-1));
            } else
            { return; }
        }

        // 1/x
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
            textBox1.Text = Convert.ToString((1 / Convert.ToDouble(textBox1.Text)));
            }
            else
            { return; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false) textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            plus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            minus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mnozh = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dilen = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }
        // seoigjdrtjghpdtjhio ;tf'hk fp[tg
        private void button20_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox1.Tag));
            }
            if (minus)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox1.Tag));
            }
            if (mnozh)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Tag));
            }
            if (dilen)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox1.Tag));
            }
        }
    }
}
