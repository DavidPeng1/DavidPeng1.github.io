using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hackathon05_1
{

    public partial class Form1 : Form
    {
        private List<string> lines;
        public Form1()
        {
            InitializeComponent();
            var filePath =
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "生命靈數.txt");


            if (File.Exists(filePath))
            {
                // 把檔案文字讀進來lines變數中
                lines = File.ReadAllLines(filePath).ToList();
            }
            else
            {
                MessageBox.Show("檔案不存在");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 先計算靈數
            // 方式一 (好懂)
            int lifeNumber = dateTimePicker1.Value
                .ToString("yyyyMMdd").Sum(c => c - '0') // 第一輪拆字相加
                .ToString().Sum(c => c - '0')// 第二輪拆字相加
                .ToString().Sum(c => c - '0');// 第三輪拆字相加

            // 方式二 (比較不浪費效能的辦法)
            lifeNumber = dateTimePicker1.Value
                .ToString("yyyyMMdd").Sum(c => c - '0');

            while (lifeNumber > 9)
            {
                lifeNumber = lifeNumber.ToString().Sum(c => c - '0');
            }

            // 取得星座名稱
            var starName= StarSigns.GetStarName(dateTimePicker1.Value);

            // 星座名稱 & 靈數 ; 去文件中找對應的訊息
            var titleIndex = lines.FindIndex(line=>line.Contains(starName));
            var message = lines[titleIndex + 2 * lifeNumber];

            // 輸出
            label2.Text = "關於你" + Environment.NewLine +
                "你的星座是" + starName + Environment.NewLine +
                message;                ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
