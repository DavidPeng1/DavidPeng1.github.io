using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon06
{
    internal class Program
    {
        /*
         * 中華民國的 稅率級距表如下：
         * 年收入 0          ~ 540,000    : 5%
         * 年收入 540,001    ~ 1,210,000  : 12%
         * 年收入 1,210,001  ~ 2,420,000  : 20%
         * 年收入 2,420,001  ~ 4,530,000  : 30%
         * 年收入 4,530,001  ~ 10,310,000 : 40%
         * 年收入 10,310,001 ~            : 50%
         * 撰寫一個程式可以輸入年收入，然後依照上面的公式計算應繳納稅額。
         * 請使用 Decimal 。
         * 
         * 已完成
         * 
         */
        static void Main(string[] args)
        {

            //條件分支應用 所得稅率

            Console.Write("請輸入個人收入：");
            int num = Convert.ToInt32(Console.ReadLine());//設定個人收入

            decimal g = GetTax(num); // 使用Decimal
            int tax1 = Convert.ToInt32(Math.Round(g, 0));

            Console.WriteLine("應繳金額為：{0}", tax1);
            Console.ReadLine();
        }


        public static decimal GetTax(int num)
        {
            ////    double tax1;

            ////    if (num <= 540000)  tax1 = num * 0.05;

            ////    if (num <= 1210000) tax1 = num * 0.12;

            ////    if (num <= 2420000) tax1 = num * 0.2;

            ////    if (num <= 4530000) tax1 = num * 0.3;

            ////    if (num <= 10310000) tax1 = num * 0.4;

            ////    if (num >= 10310001)  tax1 = num * 0.5;

            ////    return (decimal) num;
            ////}


            int tax = 0;
            int tt = 0;
            int[] ra = { 0, 540000, 1210000, 2420000, 4530000, 10310000 };
            int[] rate = { 5, 12, 20, 30, 40, 50 };

            int x = 88000; //免稅額+
            int y = 90000; //標準扣除額
            int z = 20000; //薪資所得扣除額         //其他特別扣除不討論 ..
                           //所得淨額 = 所得總額 + 免稅額 + 一般扣除(列舉扣除) - 特別扣除額
            int tx = num - x - y - z;
            Console.WriteLine("所得淨額為：{0}", tx);

            //取得所得淨額級距
            int idx = 0;
            for (int i = 0; i < ra.Length; i++)
            {
                if (tx < ra[i])
                {
                    idx = i;
                    break;
                }
                if (tx > ra[i])
                {
                    idx = i;
                }
            }

            //// Console.WriteLine("所得級距在 {0} 級：", idx);

            //計算累進差額
            int dtax = 0;
            for (int j = 0; j < idx - 1; j++)
            {

                dtax = dtax + Convert.ToInt32((ra[j + 1] - ra[j]) * (rate[idx - 1] - rate[j]) * 0.01);

            }
            //// Console.WriteLine("累進差額： {0}", dtax);

            //計算應繳所得
            tax = Convert.ToInt32(tx * rate[idx - 1] * 0.01) - dtax;
            return tax;


        }
    }
}
