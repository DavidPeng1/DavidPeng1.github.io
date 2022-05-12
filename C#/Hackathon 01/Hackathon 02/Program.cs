using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon02
{
    /* Windows Application
     * 設計一個程式，可以互相換算攝氏與華氏溫度。
     * F = 9/5 * C + 32
     * C = (F 32) * 5/9
     * 畫面配置請參照圖例完成
     * 
     * 已完成
     * 
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
