using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _23_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            Console.WriteLine($"{type.Name}");
            Console.WriteLine($"{type.FullName}");

            Assembly assembly = type.Assembly;
            Console.WriteLine($"{assembly.FullName}");
            
            object obj = assembly.CreateInstance("_23_Reflection.Student");
            Console.WriteLine($"obj是否为Student类型：{obj is Student}");
            
            MethodInfo m = type.GetMethod("SetName");
            object result = m.Invoke(obj,new object[] { "你好"});
            Console.WriteLine($"调用方法返回值：{result},对象属性值：{((Student)obj).Name}");

            PropertyInfo namePro = type.GetProperty("Name");
            Console.WriteLine($"{namePro.Name}");
            Console.WriteLine($"属性值:{namePro.GetValue(obj)}");

            FieldInfo fieldInfo = type.GetField("name");
            Console.WriteLine($"字段值：{fieldInfo.GetValue(obj)}");


        }
    }
    class Student
    {
        public Student()
        {

        }
        public Student(string name)
        {
            Name = name;
            this.name = name;
        }

        public string name;
        public string Name { get; set; }

        public string SetName(string name)
        {
            Name = name;
            this.name = name;
            return "111";
        }

    }
}
