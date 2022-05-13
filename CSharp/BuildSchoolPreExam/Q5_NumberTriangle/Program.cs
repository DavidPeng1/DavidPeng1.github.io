using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_NumberTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q5_NumberTriangle");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
            /* 輸入 1~9的整數作為層數
             * 畫面輸出
             * 輸入層數(1~9) : 5
             * 55555
             *  4444
             *   333
             *    22
             *     1  
             */

            // 已完成
            Console.Write("輸入層數(1~9) : ");
            int width = int.Parse(Console.ReadLine());

            for (int row = width; row >= 1; row--)
            {
                //空白區
                for (int counter = 1; counter <= width - (row); counter++)
                    Console.Write(" ");
                //實體區
                for (int counter = 1; counter <= row; counter++)
                    Console.Write($"{row}");
                //列結束要換行
                Console.WriteLine();
            }


            Console.Write("輸入層數(1~9) : ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                //空白區
                for (int counter = 1; counter <= row-1 ; counter++)
                    Console.Write(" ");
                //實體區
                for (int counter = 1; counter <= n-(row-1) ; counter++)
                    Console.Write($"{row}");
                //列結束要換行
                Console.WriteLine();
            }

            // 讓程式畫面保留, 按Enter後結束
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("按 任意鍵 後結束 ......");
            Console.ReadKey();
        }
    }
}
