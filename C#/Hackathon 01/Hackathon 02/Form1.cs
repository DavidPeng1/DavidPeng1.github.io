using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //textBox1.Text += btn.Text;
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
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            double temp = System.Double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                label1.Text = $"結果 : {temp} ℃ = {(temp * 9 / 5) + 32 } ℉ ";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = $"結果 : {temp} ℉ = {(temp - 32) * 5 / 9 } ℃ " ;
            }
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
