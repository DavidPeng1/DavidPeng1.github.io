using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01
{
    /* Console Application
     * 使用 Console.ReadLine() 讀取一個整數 max
     * 至少大於 90)，在螢幕上用 WriteLine 分行顯示
     * 1~max ，其中可被 3 整除者替換為 Build ，可被
     * 5 整除者替換為 School ，可以被 3 和 5 同時整
     * 除者替換為 Dann 。
     * 
     * 已完成
     * 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 已完成
            Console.Write("輸入一個至少大於90的整數：");
            int num = int.Parse(Console.ReadLine()); // 輸入字串
            Console.WriteLine(" "); // 空一格

            if (num >= 90)
            {
                int counter = 1;
                for (; counter <= num; counter++) // 控制迴圈數為 100
                {
                    if (counter % 3 == 0 && counter % 5 == 0)
                    {
                        Console.WriteLine("Dann");
                        continue;
                    }
                    if (counter % 3 == 0)
                    {
                        Console.WriteLine("Build");
                        continue;
                    }
                    if (counter % 5 == 0)
                    {
                        Console.WriteLine("School");
                        continue;
                    }
                    Console.WriteLine($"{counter}");// 如果沒有跳過, 則印出
                }
            }
            else
            {
                Console.WriteLine("請輸入大於90的整數");
            }


            int max = 99; // int.Parse(Console.ReadLin());
            var lines=Enumerable.Range(1,max)
                .Select(x => 
                x% 15 ==0? "AA":
                x%3 == 0? "BB":
                x%5 == 0? "CC" : $"{x}"
                );
            Console.WriteLine(
                String.Join(Environment.NewLine, lines)
                );

            // 讓程式畫面保留, 按Enter後結束
                Console.WriteLine("\n");
                Console.WriteLine("按 任意鍵 後結束 ......");
                Console.ReadKey();
            
        }
    }
}
