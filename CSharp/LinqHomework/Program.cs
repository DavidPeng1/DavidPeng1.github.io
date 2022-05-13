using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            //影片資料集合
            List<Video> videoList = new List<Video>() {
                new Video() { Name = "天竺鼠車車", Country = "日本", Duration = 2.6, Type = "動漫" },
                new Video() { Name = "鬼滅之刃", Country = "日本", Duration = 25, Type = "動漫" },
                new Video() { Name = "鬼滅之刃-無限列車", Country = "日本", Duration = 100, Type = "電影" },
                new Video() { Name = "甜蜜家園SweetHome", Country = "韓國", Duration = 50, Type = "影集" },
                new Video() { Name = "The 100 地球百子", Country = "歐美", Duration = 48, Type = "影集" },
                new Video() { Name = "冰與火之歌Game of thrones", Country = "歐美", Duration = 60, Type = "影集" },
                new Video() { Name = "半澤直樹", Country = "日本", Duration = 40, Type = "影集" },
                new Video() { Name = "古魯家族：新石代", Country = "歐美", Duration = 90, Type = "電影" },
                new Video() { Name = "角落小夥伴電影版：魔法繪本裡的新朋友", Country = "日本", Duration = 77, Type = "電影" },
                new Video() { Name = "TENET天能", Country = "歐美", Duration = 80, Type = "電影" },
                new Video() { Name = "倚天屠龍記2019", Country = "中國", Duration = 58, Type = "影集" },
                new Video() { Name = "下一站是幸福", Country = "中國", Duration = 45, Type = "影集" },
            };

            //人物資料集合
            List<Person> personList = new List<Person>()
            {
                new Person() { Name = "Bill", CountryPrefer = new List<string>() { "中國", "日本" }, TypePrefer = new List<string>() { "影集" } },
                new Person() { Name = "Jimmy", CountryPrefer = new List<string>() { "日本" }, TypePrefer = new List<string>() { "動漫", "電影" } },
                new Person() { Name = "Andy", CountryPrefer = new List<string>() { "歐美", "日本" }, TypePrefer = new List<string>() { "影集", "電影" } },
            };

            // 1. 找出所有日本的影片名稱 ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有日本的影片名稱");
            //方式一
            ////var result =
            ////    videoList
            ////        .Where(v => v.Country == "日本")
            ////        .Select(v => v.Name)
            ////        .ToList();
            
            //方式二
            //var step1 = videoList.Where(v => v.Country == "日本");
            //var step2 = step1.Select(v => v.Name);

            // 輸出方式一 (此題目不用foreach)
            ////foreach (var item in step2) // 用foreach把資料轉出來
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// 輸出方式二
            //var output1 = string.Join(",",step2);
            //Console.WriteLine(output1);

            //// 輸出方式三
            //Console.WriteLine(string.Join("\n", videoList.Where(v => v.Country == "日本").Select(v => v.Name)));
            
            // 輸出方式四
            Console.WriteLine(
                string.Join("\n", videoList
                .Where(q1 => q1.Country == "日本")
                .Select(q1 => q1.Name))
                );

            // 2. 找出所有歐美的影片且類型為"影集"的影片名稱 ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有歐美的影片且類型為'影集'的影片名稱");
            Console.WriteLine(
                                string.Join("\n", 
                                    videoList
                                    .Where(q2 => q2.Country == "歐美" && q2.Type == "影集")
                                    .Select(q2 => q2.Name))
                                );

            // 3. 是否有影片片長超過120分鐘的影片 ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 是否有影片片長超過120分鐘的影片");
            var stepTime1 = videoList.Any(q3 => q3.Duration >= 120);
            // Console.WriteLine(stepTime1);
            if (stepTime1)
                Console.WriteLine("有");
            else
                Console.WriteLine("沒有");


            // 4. 請列出所有人的名稱，並且用大寫英文表示，ex: Bill -> BILL ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 請列出所有人的名稱，並且用大寫英文表示");
            // Console.WriteLine(string.ToUpper("\n\t",personList.name);
            var stepPerson1 = personList.Select(v=> v.Name.ToUpper()); // 將personList的人名轉大寫, 回傳到stepPerson1
            Console.WriteLine(string.Join(" ",stepPerson1)); // 輸出stepPerson1的人名


            // 5. 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名，ex: No1: 天竺鼠車車 ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名");
            var sortByDuration =videoList.OrderByDescending(v => v.Duration); // 從大到小排列
            // var sortByDuration = videoList.OrderBy(v => v.Duration); // 如果要從片長短(小)到長(大)排列

            int index = 1;
            foreach (var v in sortByDuration )
            {
                Console.WriteLine($"NO{index}: {v.Name}");
                index++;
            }


            // 6. 將所有影片進行以"類型"分類，並顯示以下樣式(注意縮排) ==> 完成
            /* 
            動漫:
                天竺鼠車車
                鬼滅之刃
            */
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片進行以'類型'分類");
            //Console.Write("動漫 :\n\t");
            //Console.WriteLine(string.Join("\n\t", videoList.Where(v => v.Type == "動漫").Select(v => v.Name)));
            //Console.Write("電影 :\n\t");
            //Console.WriteLine(string.Join("\n\t", videoList.Where(v => v.Type == "電影").Select(v => v.Name)));
            //Console.Write("影集 :\n\t");
            //Console.WriteLine(string.Join("\n\t", videoList.Where(v => v.Type == "影集").Select(v => v.Name)));
            
            var videoByType = videoList.GroupBy(v => v.Type);
            foreach (var v in videoByType)
            {
                Console.WriteLine("\n" + v.Key +":");
                foreach(var x in v)
                {
                    Console.Write("\n\t" + x.Name);
                }
            }
            Console.WriteLine("");

            var result6 = videoList.GroupBy(v => v.Type)
                .Select(g => $"{g.Key}:{string.Concat ( g.Select(v=>"\n\t" + v.Name))}");

            result6 = from v in videoList
                      group v by v.Type into g
                      select $"{g.Key}:{string.Concat(g.Select(v => "\n\t" + v.Name))}";

            Console.WriteLine(
                String.Join(Environment.NewLine, result6)
                );




            // 7. 找到第一個喜歡歐美影片的人 ==> 完成
            Console.WriteLine($"{Environment.NewLine}Q: 找到第一個喜歡歐美影片的人");
            //// 方式一
            //Console.WriteLine(string.Join("\n", personList.First(v => v.CountryPrefer.Exists(x=> x=="歐美")).Name)); // Exiasts 找條件 
            // 方式二
            Console.WriteLine(string.Join("\n", personList.First(v => v.CountryPrefer.Contains("歐美")).Name)); // Contains 找物件


            // 8. 找到每個人喜歡的影片(根據國家以及類型)，ex: Bill: 天竺鼠車車, 倚天屠龍記2019
            Console.WriteLine($"{Environment.NewLine}Q: 找到每個人喜歡的影片");

            var result8 = 
                personList.Select(p =>
                   $"{p.Name}:{"..."}"
                    );


            personList.Select(p =>
                   $"{p.Name}:{videoList.Where(v=> " "== " ")}"
                    );

            //Console.WriteLine(
            //    String.Join()
            //    );










            foreach (var person in personList)
            {
                Console.Write(person.Name + " : ");
                IEnumerable<string> result = new List<string>();
                var CP = new List<string>();
                int index1 = 1;
                foreach (var person2 in person.CountryPrefer)
                {
                    CP = videoList.Where(v => v.Country == person2).Select(v => v.Name).ToList();
                    var TP = new List<string>();
                    foreach (var person3 in person.TypePrefer)
                    {
                        TP = videoList.Where(v => v.Type == person3).Select(v => v.Name).ToList();
                        result = TP.Intersect(CP);
                        Console.Write(index1 == 2 ? ", " + String.Join(", ", result) : String.Join(", ", result));
                    }
                    index1++;
                }
                Console.WriteLine();
            }

            // 9. 列出所有類型的影片總時長，ex: 動漫: 100min
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有類型的影片總時長");
            foreach (var b in videoList.GroupBy(v => v.Type))
                Console.WriteLine(b.First().Type + " : " + b.Sum(v => v.Duration)+ " min " );

            Console.WriteLine(
                String.Join(Environment.NewLine,
                    videoList.GroupBy(v => v.Type) // 將影片以類型 分組 每一組在考慮怎麼轉變
                     .Select(g => $"{g.Key} : {g.Sum(v => v.Duration) } min") // 每組 轉型成 字串 => "{組名} : {組內累加時長}min"
                    )
                );

            // 10. 列出所有國家出產的影片數量，ex: 日本: 3部
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有國家出產的影片數量");
            // 影片以國家分組
            // 每組轉型成字串 => {組名}{組內影片數量}
            ////var resilt10 = videoList.GroupBy(v => v.Country)
            ////     .Select(g => $"{ g.Key}:{ g.Conut()}部");

            ////resilt10 = from v in videoList
            ////           group v by v.Country into g
            ////           select $"{ g.Key}:{ g.Conut()}部";
            
            ////Console.WriteLine(
            ////    string.Join(Environment.NewLine,
            
            
            
            var videoByAmount = videoList.GroupBy(x => x.Country);
            foreach (var x in videoByAmount)
            {

            }
            Console.ReadLine();
        }
    }
}
