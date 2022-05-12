using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon02_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            // 數字按鈕
            // this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button4.Click += new System.EventHandler(this.button3_Click);
            this.button5.Click += new System.EventHandler(this.button3_Click);
            this.button6.Click += new System.EventHandler(this.button3_Click);
            this.button7.Click += new System.EventHandler(this.button3_Click);
            this.button8.Click += new System.EventHandler(this.button3_Click);
            this.button9.Click += new System.EventHandler(this.button3_Click);
            this.button10.Click += new System.EventHandler(this.button3_Click);
            this.button11.Click += new System.EventHandler(this.button3_Click);
            this.button12.Click += new System.EventHandler(this.button3_Click);


            // . 按鈕
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button13.Click += new System.EventHandler(this.button3_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 鍵盤數字按鈕
        private void button3_Click(object sender, EventArgs e)
        {
            Button theBnt=(Button)sender;
            textBox1.Text += theBnt.Text;
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==String.Empty)
            {
                textBox1.Text = "0";
            }

            button13.Enabled = false;
        }


        // 轉換與清除按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            if(radioButton1.Checked)
            {
                double F = input * 9.0 / 5.0 - 32.0;
                label1.Text = $"結果 : {input} ℃ = {F.ToString("#.###")}℉"; // #.### 小數點三位
            }
            if(radioButton2.Checked)
            {
                double C = (input -32.0 )*5.0 / 9.0;
                label1.Text = $"結果 : {input} ℉ = {C.ToString("#.###")}℃"; // #.### 小數點三位
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            //清空文字
            label1.Text= String.Empty;
            // 小數點啟用
            button13.Enabled = true;
        }

    }
}
