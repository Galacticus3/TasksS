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
        bool dilenzero = false;
        bool flag = false;
                
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
                if (flag == true) textBox1.Text = ""; 
                textBox1.Text = textBox1.Text + "1";
                flag = false;
            }
            else
            { return; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
                if (flag == true) textBox1.Text = ""; 
                textBox1.Text = textBox1.Text + "2";
                flag = false;
            } else
            { return; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "3"; 
            } else
            { return; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "4"; 
            } else
            { return; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "5"; 
            } else
            { return; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "6"; 
            } else
            { return; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "7"; 
            } else
            { return; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "8"; 
            } else
            { return; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           if (dilenzero == false)
            {
            textBox1.Text = textBox1.Text + "9"; 
            } else
            { return; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           if (dilenzero == false)
            {
              if (textBox1.Text!="")  textBox1.Text = textBox1.Text + "0"; 
            } else
            { return; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
            plus = false;
            minus = false;
            mnozh = false;
            dilen = false;
            dilenzero = false;
            flag = false;
        }

        // sqrt
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            } else
            { return; }
        }

        // + -
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
                textBox1.Text = Convert.ToString((Convert.ToDouble(textBox1.Text)) * (-1));
            } else
            { return; }
        }

        // 1/x
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
            textBox1.Text = Convert.ToString((1 / Convert.ToDouble(textBox1.Text)));
            }
            else
            { return; }
        }

        // ,
        private void button11_Click(object sender, EventArgs e)
        {
            if (dilenzero == false)
            {
                if (plus == false && minus == false && mnozh == false && dilen == false && (textBox1.Text == "")) textBox1.Text = textBox1.Text + "0";
                if (textBox1.Text.Contains(",") == false) textBox1.Text = textBox1.Text + ",";
            }
            else
            { return; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
            plus = true;
            textBox1.Tag = textBox1.Text;
           // textBox1.Text = "";
            flag = true;
            }
            else
            { return; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
            minus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
             }
            else
            { return; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
            mnozh = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
             }
            else
            { return; }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && dilenzero == false)
            {
            dilen = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
             }
            else
            { return; }
        }
        // =
        private void button20_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) + Convert.ToDouble(textBox1.Text));
            }
            if (minus)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) - Convert.ToDouble(textBox1.Text));
            }
            if (mnozh)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) * Convert.ToDouble(textBox1.Text));
            }
            if (dilen)
            {
                if (Convert.ToDouble(textBox1.Text) == 0) 
                 { textBox1.Text = "На ноль нельзя!";
                 plus = false; 
                 minus = false;
                 mnozh = false;
                 dilen = false;
                 dilenzero = true;
                 flag = false;
                 }
                else 
                 { textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) / Convert.ToDouble(textBox1.Text)); }
            }
        }
    }
}
