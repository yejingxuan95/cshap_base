using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Param01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "萧炎";
            Console.WriteLine($"前：{stu.GetHashCode()},{stu.Name}");

            Test(stu);
            Console.WriteLine($"后：{stu.GetHashCode()},{stu.Name}");
        }
        static void Test(Student student) 
        {
            Console.WriteLine($"方法内前：{student.GetHashCode()},{student.Name}");
            //student = new Student();
            student.Name = "罗峰";
            Console.WriteLine($"方法内后：{student.GetHashCode()},{student.Name}");
        }
    }
    class Student
    {
        public string Name { get; set; }
    }
}
