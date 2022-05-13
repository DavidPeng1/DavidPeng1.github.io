using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon04
{
    /* 猜數字遊戲
     * Windows Application
     * 電腦從 0~9 亂數挑選 4 的不重複的數字，讓使用者猜。
     * 如果玩家猜測的某一個數字和電腦挑選的相同，但順序不同，
     * 則以 B 表示；若是該數字連順序都相同則以 A 表示。 
     * 4A 及代表遊戲成功結束。
     * 例如：電腦挑出的數字為 5461
     * 玩家猜 5038 ，則為 1A0B
     * 玩家猜 5048 ，則為 1A1B
     * 玩家猜 9872 ，則為 0A0B
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
