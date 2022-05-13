using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon06_1
{
    public class IncomeTaxLevel
    {
        public decimal Rate { get; set; }
        public decimal IncomeLowerBound  { get; set; }
    }
    internal class TaxOperation
    {
        private static  List<IncomeTaxLevel> _taxLevels = new List<IncomeTaxLevel>
        {
            new IncomeTaxLevel { IncomeLowerBound = 1_0310_000m, Rate = 0.5m },
            new IncomeTaxLevel { IncomeLowerBound = 4_530_000m, Rate = 0.5m },
            new IncomeTaxLevel { IncomeLowerBound = 2_420_000m, Rate = 0.5m },
            new IncomeTaxLevel { IncomeLowerBound = 1_210_000m, Rate = 0.5m },
            new IncomeTaxLevel { IncomeLowerBound = 540_000m, Rate = 0.5m },
        };

        public static decimal ComputeTax (decimal Income)
        {
            var validLevels = _taxLevels
                .Where(lv => lv.IncomeLowerBound < Income);

            // 剩下還沒計算稅的收入
            decimal remainIncome = Income;
            var answer = validLevels.Sum( lv =>
                {
                    // 超出 此及下限的金額
                    decimal over =remainIncome - lv.IncomeLowerBound;

                    // 更新剩下的稅率
                    remainIncome = lv.IncomeLowerBound;

                    // 超出下限的值 乘上 稅率 , 等於此級要繳的稅金
                    return over * lv.Rate ;
                } 
            );


            return answer;

        }
    }
}
