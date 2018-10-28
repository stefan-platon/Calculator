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
        int a, rez, b; double ca;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox2.Text);
            textBox1.Text = textBox1.Text + a + " + ";
            textBox2.Clear();
            op = "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox2.Text);
            textBox1.Text = textBox1.Text + b;
            textBox2.Clear();
            if (op == "+")
                rez = a + b;
            if (op == "-")
                rez = a - b;
            if (op == "*")
                rez = a * b;
            if (op == "/")
                rez = a / b;
            textBox2.Text = "" + rez;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox2.Text);
            textBox1.Text = textBox1.Text + a + " - ";
            textBox2.Clear();
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox2.Text);
            textBox1.Text = textBox1.Text + a + " * ";
            textBox2.Clear();
            op = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox2.Text);
            ca = Convert.ToDouble(a);
            textBox1.Text = textBox1.Text + a + " / ";
            textBox2.Clear();
            op = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }
    }
}
