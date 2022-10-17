using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDAL studentDAL = new StudentDAL();
            //int? num = studentDAL.InsertStudentB();
            IEnumerable<Student> list = studentDAL.GetStudentList1();
            var result = from item in list
                           where item.Age > 18
                           select item;
            foreach (Student item in result)
            {
                Console.WriteLine($"{item.Name},{item.Age},{item.Gender}");

            }
            Console.ReadKey();
        }
    }
}
