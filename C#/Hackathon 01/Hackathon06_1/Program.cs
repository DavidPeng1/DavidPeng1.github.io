using System;

namespace Hackathon06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.Write("請輸入個人收入：");

            var incom = decimal.Parse(
                Console.ReadLine()
                .Replace(",", string.Empty)
                );

            var answer = TaxOperation.ComputeTax(incom);

            Console.WriteLine("應繳金額為：" + answer.ToString("#,###,###"));
            Console.WriteLine("- - - - - - - - - - - - - ");
            }

            Console.ReadLine();
        }
    }
}
