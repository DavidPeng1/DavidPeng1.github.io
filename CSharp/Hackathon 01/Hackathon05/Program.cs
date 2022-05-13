using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon05
{
    /* 生命靈數
     * Windows Forms Application
     * 設計一個使用西元生日計算生命靈數，並依據其星座給予評論的程式，
     * 請使用 DateTimePicker 作為日期輸入使用
     * 生命靈數的計算方式 (1980 年 8 月 16 日)
     * 生命靈數就是 1+9+8+0+8+1+6=33
     * 3+3=6
     * 結果為 6 ( 這個可能會用到遞迴運算 )
     */
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
