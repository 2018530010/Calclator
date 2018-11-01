using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        int prevValue = 0;

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            prevValue = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // = 눌렀을때
            int current = int.Parse(textBox1.Text);

            if (label1.Text == "+")
            {
                textBox1.Text = (prevValue + current).ToString();
            }
            else if (label1.Text == "-")
            {
                textBox1.Text = (prevValue - current).ToString();

            }
            else if (label1.Text == "*")
            {
                textBox1.Text = (prevValue * current).ToString();

            }
            else if (label1.Text == "/")
            {
                textBox1.Text = (prevValue / current).ToString();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            prevValue = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            prevValue = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            prevValue = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
