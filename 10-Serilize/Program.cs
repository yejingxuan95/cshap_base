using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _10_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化
            //using (FileStream fw = new FileStream(@"C:\Users\11432\Desktop\new1111.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
            //    BinaryFormatter binary = new BinaryFormatter();
            //    Student student = new Student();
            //    student.Name = "国庆";
            //    student.Age = 10;
            //    binary.Serialize(fw,student);
            //}
            using (FileStream fr = new FileStream(@"C:\Users\11432\Desktop\new1111.txt",FileMode.Open,FileAccess.Read)) {
                Student student = new Student();
                BinaryFormatter binary = new BinaryFormatter();
                student = (Student) binary.Deserialize(fr);
                Console.WriteLine($"{student.Name}，{student.Age}"); 
            }
            Console.ReadKey();
        }
    }

    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
