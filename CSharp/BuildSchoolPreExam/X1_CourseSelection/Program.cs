using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_CourseSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 學號 : S11001
             * 姓名 : Dann
             * 選課 :
             *          微積分 , 4學分
             *          線性代數 , 3學分
             *          普通物理 , 3學分
             *          物理實驗 , 1學分
             * 總共11學分
             * - - - - - - - - - - - - - - - -
             * 學號 : S11002
             * 姓名 : Bill
             * 選課 :
             *          視唱 , 3學分
             *          和弦 , 4學分

             * 總共7學分
             * - - - - - - - - - - - - - - - -
            */

            Student student1 = new Student();
            //以下由你完善，設定學生的個資、選課
            student1.Id = "S11001";
            student1.Name = "Dann";
            student1.Courses = new Course[4]
            {
                 new Course{CourseName = "微積分", Credit=4},
                 new Course{CourseName = "線性代數", Credit=3},
                 new Course{CourseName = "普通物理", Credit=3},
                 new Course{CourseName = "物理實驗", Credit=1},
            };

            //以上由你完善
            student1.ShowInformation();


            Student student2 = new Student();
            //以下由你完善，設定學生的個資、選課
            student2.Id = "S11002";
            student2.Name = "Bill";
            student2.Courses = new Course[2]
            {
                 new Course{CourseName="視唱", Credit=3},
                 new Course{CourseName="和弦", Credit=4},
            };


            //以上由你完善
            student2.ShowInformation();

            // 結束欄位
            Console.WriteLine("");
            Console.WriteLine("- - - 按任意鍵結束 - - - - - - - - - - - -");
            Console.ReadLine();
        }
    }

    public class Student
    {
        //須要什麼成員，自行設計

        public string Id { get; set; } // 宣告學號

        public string Name { get; set; } // 宣告姓名

        public Course[] Courses { get; set; } // 宣告課程陣列

        public void ShowInformation()//自我介紹
        {
            //輸出參考示意圖格式
            //初始化學生1課程清單              Console.WriteLine($"學號 : {Id} \n姓名 : {Name}\n選課 : ");
            Console.WriteLine($"學號 : " + Id);
            Console.WriteLine($"姓名 : " + Name);
            Console.WriteLine($"選課 : " );
            int sum = 0;
            for (int i = 0; i < Courses.Length; i++)
            {
                Console.WriteLine("\t"+Courses[i].CourseName +" , " + Courses[i].Credit + "學分"); // 類別類型的物件可以點屬性
                sum += Courses[i].Credit;
            }

            // foreach (Course course in Courses)
            //{
                Console.WriteLine($"總共{sum}學分");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            //}
                return;
        }
    }
    public class Course
    {
        //須要什麼成員，自行設計
        // 宣告每一個課程的物件名稱與學分
        public string CourseName { get; set; }
        public int Credit { get; set; }


    }
}
