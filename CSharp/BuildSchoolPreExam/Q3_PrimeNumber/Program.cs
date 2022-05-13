using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q3_PrimeNumber");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            /*
             * 輸出2~200內的所有質數
             * 2
             * 3
             * 5
             * 7
             * 11
             * 13
             * 17
             * 19
             * 23
             * 29
             * 31
             * 37
             * .....
             * 157
             * 163
             * 167
             * 173
             * 179
             * 181
             * 191
             * 193
             * 197
             * 199
             */
            
            // 已完成

            bool a; // 聲明一個布林(bool)值, 用來判斷是否是為質數 (true 或 false)
            for(int i = 2; i <=200; i++) //循環200以內的數
            {
                a = true; // 每次循環都把bool a 的值設置為true                 
                //for (int j = 2; j < i; j++) //開始判斷質數循環
                for (int j = 2; j <= Math.Sqrt(i); j++) //開始判斷質數循環
                    {
                    if (i % j == 0) // 公式 ; 能被整除就不是質數
                    {
                        a = false;
                        break;
                    }
                }

                // 輸出
                if (a) // 如果a是質數
                {
                    Console.WriteLine($"{ i}");
                }
            }


            // 讓程式畫面保留, 按Enter後結束
            Console.WriteLine("\n");
            Console.WriteLine("按 任意鍵 後結束 ......");
            Console.ReadKey();
        }
    }
}
