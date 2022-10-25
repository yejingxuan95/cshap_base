using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Param02_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine($"{stu.GetHashCode()}");
            bool b = StudentFactory.Create("萧炎", 21,out stu);
            if (b)
            {
                Console.WriteLine($"{stu.GetHashCode()},{stu.Name},{stu.Age}");
            }
        }
    }
    class Student
    {
        public int Age { get; set; }
        public string  Name { get; set; }
    }
    class StudentFactory
    {
        public static bool Create(string name,int age,out Student student) {
            student = null;
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (age<10 || age>80)
            {
                return false;
            }
            student = new Student() { Name = name, Age = age };
            Console.WriteLine($"方法内：{student.GetHashCode()}");
            return true;
        }
    }
}
