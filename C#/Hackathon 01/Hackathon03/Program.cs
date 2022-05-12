using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon03
{
    /*計算個別字串數量
     * Console Application
     * 輸入一個有意義的英文敘述字串，計算其個別單字數
     * 量 不區分大小寫 ))，例如 “To be or not to be"會得到以下結果：
     * to : 2
     * be : 2
     * or : 1
     * not : 1
     * 
     * 已完成
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //統計出字串中，下雪出現的次數，並每次出現的索引位置；
            // string text = "To be or not to be";
            Console.Write("輸入一個有意義的英文敘述字串 : ");
            string text = Console.ReadLine(); // 輸入字串
            var text1 = text.ToLower().Split(' '); // 全部轉小寫(ToLower()) ; 用空格區分S(' ')

            var total = text1.GroupBy(x => x);
            foreach(var group in total)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
            }
            //////////////////////
            ///
            ///第二種解法
            Console.Write("輸入一個有意義的英文敘述字串 : ");
            var lines = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .GroupBy(x=>x)
                .Select(g=>$"{g.Key}:{g.Count()}");

            Console.WriteLine(
                String.Join(Environment.NewLine,
                lines)
                );

            Console.ReadLine();


        }    
    }
}
