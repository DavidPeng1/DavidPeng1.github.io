using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q2_Palindrome");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            /* 輸入一段文字, 判斷是否是迴文
             * 上海自來水來自上海 [ 是迴文]
             * 蜜蜂採蜂蜜
             * 天上龍捲風捲龍上天
             * 
             * 來來來你來你來
             * [非迴文]
            */

            string str = Console.ReadLine(); // 輸入字串
            string res = "";
            // 把str內容反轉存在res
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i];
            }
            //比較 res 與 str
            if (res == str)
            {
                Console.WriteLine("是迴文"); // 在str+
            }
            else
            {
                Console.WriteLine("不是迴文"); // 在str+
            }

            // 方式二
            string words = Console.ReadLine(); // 輸入字串
            bool isPalindome = true;
            //檢查 不通過就設 False
            for (int j = 0; j < words.Length/2 ; j++)
            {
                if( words[0+j] != words [(words.Length -1) -j] )
                {
                    isPalindome = false;
                    break;
                }
            }
            if (isPalindome)
                Console.WriteLine("是迴文");
            else
                Console.WriteLine("不是迴文");

            // 讓程式畫面保留, 按Enter後結束
            Console.WriteLine("\n");
            Console.WriteLine("按 任意鍵 後結束 ......");
            Console.ReadKey();
        }
    }
}
