using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand = string.Empty;
        string equals = string.Empty;
        char calc;
        double ans = 0.0;

        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand = input;
            calc = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand = input;
            calc = '-';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand = input;
            calc = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand = input;
            calc = '/';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            operand = string.Empty;
            equals = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            equals = input;
            double num1;
            double num2;
            double.TryParse(operand, out num1);
            double.TryParse(equals, out num2);
            if( calc == '+')
            { 
                ans = num1 + num2;
                textBox1.Text = ans.ToString();
            }
            else if( calc == '-')
            {
                ans = num1 - num2;
                textBox1.Text = ans.ToString();
            }
            else if( calc == '*')
            {
                ans = num1 * num2;
                textBox1.Text = ans.ToString();
            }
            else if( calc == '/')
            {
                if (num2 != 0)
                {
                    ans = num1 / num2;
                    textBox1.Text = ans.ToString();
                }
                else
                {
                    textBox1.Text = "UNDEFINED";
                }
            }
        }
    }
}
