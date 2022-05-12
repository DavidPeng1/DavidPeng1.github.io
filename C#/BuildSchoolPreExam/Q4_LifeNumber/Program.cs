using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_LifeNumber
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            Console.WriteLine("Q4_LifeNumber");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = ");
            Console.WriteLine(" ");
            /*輸入 : 生日西元年 月 日
             * 輸出 : 此生日的生命靈數
             * [ 生命靈數算法 https://lms.ndmctsgh.edu.tw/sysdata/81/1981/doc/ac6d6cd4aac9c3aa/attach/20222.htm]
             */

            // 已完成, 答案是對的
            // 但程式迴圈判斷先分三次, 因為缺少判斷10位數的公式方法 ? 待研究

            //////Console.WriteLine("請輸入生日的西元年月日(YYYYMMDD)");

            //////int sum = 0;
            //////int sum1 = 0;
            //////int sum2 = 0;
            //////int num = int.Parse(Console.ReadLine());

            ////// 判斷 num 值 是否屬於個位數
            //////while (num > 0) 
            //////{
            //////    sum += num % 10;
            //////    num /= 10;
            //////}

            //////// 再判斷 sum 值 是否屬於個位數
            //////while (sum > 0)
            //////{
            //////    sum1 += sum % 10;
            //////    sum /= 10;
            //////}

            //////// 再判斷 sum1 值 是否屬於個位數
            //////while (sum1 > 0)
            //////{
            //////    sum2 += sum1 % 10;
            //////    sum1 /= 10;
            //////}

            //////Console.WriteLine(sum2);
            ///

            // 用int方式處理
            Console.WriteLine("請輸入生日的西元年月日(YYYYMMDD)");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;        //記錄個位數
            while (number > 0) // 判斷 num 值 是否屬於個位數
            {
                if (number >= 10) // 如果數字是10位數
                {
                    sum += number % 10; // 每次num的值除10後的餘數放入sum中, 記錄個位數相加
                    number = number / 10; // 將num的值除10
                }
                // else if (num < 10) // 如果是個位數
                    else if (number < 10) // 如果是個位數
                    {
                        sum += number; // sum與num相加後, 再將結果給sum
                        number = number / 10; // 將num的值除10
                    }
                if (sum >= 10) // 判斷 超過10的個位數 重新變化
                {
                    sum = sum % 10 + sum / 10; //超過10的個位數重新計算
                }
            }

            Console.WriteLine($"此生日的生命靈數 : "+sum);

            // 方式二 用int方式處理
            // 輸入
            Console.WriteLine("請輸入生日的西元年月日(YYYYMMDD)");
            string birthday = Console.ReadLine();
            int numbers= int.Parse(birthday);
            while(numbers > 9)
            {
                // 每位數相加
                numbers = SplitToAdd(numbers);
                // 19990909 > 9
                // 1+9+9+9+0+9+0+9 =....
            }
            // 出迴圈 numbers就確定<=9
            Console.WriteLine($"此生日的生命靈數 : " + numbers);

            // 方式三 用字串方式處理
            // 輸出
            while (birthday.Length >1)
            {
                birthday = SplitToAdda(birthday);
            }
            Console.WriteLine($"此生日的生命靈數 : " + birthday);

            // 讓程式畫面保留, 按Enter後結束
            Console.WriteLine("");
            Console.WriteLine("按 任意鍵 後結束 ......");
            Console.ReadKey();
        }
        static int SplitToAdd(int num) // int 方式
        {
            int result = num % 10; // 個位數
            while(num /10 >0) // 若還有十位數以上 就循環
            {
                //降一位
                num = num / 10;

                //加個位數
                result += num % 10;
            }
            return result;  
        }
        static string SplitToAdda(string nums)
        {
            int result = 0;
            // 利用字串陣列的特性, 用索引直遍歷 每個字
            for(int i=0; i<nums.Length; i++)
            {
                int n = int.Parse(nums[i].ToString());
                result += n;
            }
            return result.ToString();
        }
    }
}
