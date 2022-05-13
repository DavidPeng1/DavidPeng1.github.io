using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon05_1
{
    public class StarData
    {
        public string Name { get; set; }
        public int EndDate { get; set; }
    }
    internal class StarSigns
    {
        private static List<StarData> _starDataList 
            = new List<StarData>()
            {
                new StarData(){Name = "摩羯座" , EndDate = 1_20} ,
                new StarData(){Name = "水瓶座" , EndDate = 2_20} ,
                new StarData(){Name = "雙魚座" , EndDate = 3_21} ,
                new StarData(){Name = "牧羊座" , EndDate = 4_21} ,
                new StarData(){Name = "金牛座" , EndDate = 5_21} ,
                new StarData(){Name = "雙子座" , EndDate = 6_22} ,
                new StarData(){Name = "巨蟹座" , EndDate = 7_23} ,
                new StarData(){Name = "獅子座" , EndDate = 8_23} ,
                new StarData(){Name = "處女座" , EndDate = 9_23 } ,
                new StarData(){Name = "天秤座" , EndDate = 10_23} ,
                new StarData(){Name = "天蠍座" , EndDate = 11_21} ,
                new StarData(){Name = "射手座" , EndDate = 12_22} ,
                new StarData(){Name = "摩羯座" , EndDate = 12_32} // 摩羯座因為有年初與年末, 所以年末用12月32來判斷
            };
        public static string GetStarName(DateTime birthDate)
        {
            // 星座期間適用int, 所以生日要先轉int才能比較
            int birthday=int.Parse(birthDate.ToString("MMdd"));
            string starName=_starDataList
                .First(x=>birthday < x.EndDate)
                .Name;

            return starName;
        }
    }
}
