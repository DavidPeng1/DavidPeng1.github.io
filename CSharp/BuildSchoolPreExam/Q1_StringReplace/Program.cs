using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1_StringReplace");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            /* 將1~100顯示在畫面上
             * 遇到2的倍數顯示"螃蟹"
             * 遇到3的倍數顯示"章魚"
             * 如果同時為2跟3的倍數, 顯示 "金槍魚"
             * 顯示畫面如下
             * 1
             * 螃蟹
             * 章魚
             * 螃蟹
             * 5
             * 金槍魚
             * 7
             * 螃蟹
             * 章魚
             * 螃蟹
             * 11
             * 金槍魚
             * ....
             */

            // 已完成

            
            for (int counter = 1; counter <= 100; counter++) // 控制迴圈數為 100
            {
                // if (counter % 2 == 0 && counter % 3 == 0) // 或下列方式
                if (counter %6 == 0)
                {
                    Console.WriteLine("金槍魚");
                    continue;
                }
                if (counter % 2 == 0)
                {
                    Console.WriteLine("螃蟹");
                    continue;
                }
                if (counter % 3 == 0)
                {
                    Console.WriteLine("章魚");
                    continue;
                }

                Console.WriteLine($"{counter}");// 如果沒有跳過, 則印出
            }
     
            // 讓程式畫面保留, 按Enter後結束
            Console.WriteLine("\n");
            Console.WriteLine("按 任意鍵 後結束 ......");
            Console.ReadKey();
        }
    }
}
