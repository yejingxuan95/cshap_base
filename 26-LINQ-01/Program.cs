using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_LINQ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ简单示例
            //int[] numbers = { 2, 6, 8, 3, 17, 35, 24, 1, 5, 40, 57 };

            //var numResult = from num in numbers
            //                where num > 30
            //                select num;
            //foreach (var num in numResult)
            //{
            //    Console.Write($"{num},");
            //}
            //Console.WriteLine();
            #endregion

            #region join示例
            //List<Student> sList = new List<Student> {
            //    new Student { SID = 1 , CID = 1 , SName = "张三" },
            //    new Student { SID = 2 , CID = 2 , SName = "李四" },
            //    new Student { SID = 3 , CID = 3 , SName = "王五" },
            //    new Student { SID = 4 , CID = 4 , SName = "王二" }
            //};
            //List<Course> cList = new List<Course> {
            //    new Course { CID = 1 , CName = "英语" },
            //    new Course { CID = 2 , CName = "数学" },
            //    new Course { CID = 3 , CName = "语文" },
            //    new Course { CID = 4 , CName = "化学" }
            //};
            //var result = from s in sList
            //             join cou in cList on s.CID equals cou.CID
            //             where cou.CID > 2
            //             select new { s.SID,s.SName, cou.CName };
            //foreach (var res in result)
            //{
            //    Console.WriteLine($"{res.SID},{res.SName},{res.CName}");
            //}
            //Console.WriteLine();
            #endregion

            #region let示例
            //var groupA = new[] { 3, 4, 5, 6 };
            //var groupB = new[] { 6, 7, 8, 9 };
            //var result = from a in groupA
            //             from b in groupB
            //             let sum = a + b
            //             where sum == 12
            //             where a == 4
            //             select new { a, b, sum };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.a},{item.b},{item.sum}");
            //}
            //Console.WriteLine();
            #endregion

            #region into子句
            //var groupA = new[] { 3, 4, 5, 6 };
            //var groupB = new[] { 5, 6, 7, 8 };
            //var result = from a in groupA
            //             join b in groupB on a equals b
            //             into groupAandB        //查询延续
            //             from c in groupAandB

            //             select c;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region 标准查询运算符
            //int[] numbers = new int[] {2,4,6,7,8,9,10 };
            //int total = numbers.Sum();
            //int count = numbers.Count();
            //Console.WriteLine($"total:{total}");
            //Console.WriteLine($"count:{count}");
            //Console.WriteLine($"count:{numbers.Take(2).Sum()}");
            //Console.WriteLine($"============");
            //int total1 = Enumerable.Sum(numbers);
            //int count1 = Enumerable.Count(numbers);
            //Console.WriteLine($"total:{total1}");
            //Console.WriteLine($"count:{count1}");
            #endregion

            #region 查询表达式和查询运算符
            //var numbers = new int[] { 2, 3, 4, 5, 6, 7 };
            //int count = (from num in numbers
            //             where num > 4
            //             select num).Count();
            //Console.WriteLine($"{count}");
            #endregion

            #region 使用委托作为参数
            //Func<int, bool> func = new Func<int, bool>(IsOdd);
            //var numbers = new int[] { 2, 3, 4, 5, 6, 7 };
            //var count = numbers.Count(func);
            //Console.WriteLine($"{count}");
            #endregion
            #region 使用lambda作为参数
            //var numbers = new int[] { 2, 3, 4, 5, 6, 7 };
            //var count = numbers.Count(n => n % 2 == 1);
            //Console.WriteLine($"使用lambda作为参数:{count}");
            #endregion
            #region 使用匿名方法作为参数
            Func<int, bool> func = delegate (int n) {
                                    return n % 2 == 1;
                                    };
            var numbers = new int[] { 2, 3, 4, 5, 6, 7 };
            var count = numbers.Count(func);
            Console.WriteLine($"使用lambda作为参数:{count}");
            #endregion
        }
        static bool IsOdd(int x) {
            return x % 2 == 1;
        }
    }

    class Student
    {
        public int SID { get; set; }

        public int CID { get; set; }

        public string SName { get; set; }
    }

    class Course
    {
        public int CID { get; set; }
        public string CName { get; set; }
    }
}
