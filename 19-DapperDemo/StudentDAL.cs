using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DapperDemo
{
    public class StudentDAL
    {
        DapperHelper dapperHelper = new DapperHelper();
        
        /// <summary>
        /// 通过Sql插入单条数据（带参数），返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? InsertStudentA() {
            using (var conn = dapperHelper.GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                return conn.Execute(strSql, new { Name = "Hello", Age = 18, Gender = "male" });
            }
        }
        /// <summary>
        /// 通过SQL插入单条数据（实体参数），返回结果是影响行数
        /// </summary>
        /// <returns></returns>
        public int? InsertStudentB() 
        {
            using (var conn = dapperHelper.GetCon()) {
                conn.Open();
                string sql = "insert into Student (Name,Age,Gender) values(@Name,@Age,@Gender)";
                Student student = new Student() { Name ="1测试",Age=12,Gender="male"};
                return conn.Execute(sql,student);
            }
        }
        /// <summary>
        /// 通过SQL插入单条数据（实体参数），返回主键值
        /// </summary>
        /// <returns></returns>
        public int? InsertStudentC()
        {
            using (var conn = dapperHelper.GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                Student student = new Student
                {
                    Name = "Hello",
                    Age = 18,
                    Gender = "male"
                };
                strSql += " SELECT SCOPE_IDENTITY()";
                return conn.QueryFirstOrDefault<int>(strSql, student);
            }
        }
        /// <summary>
        /// 插入多条数据，返回结果是影响行数
        /// </summary>
        /// <returns></returns>
        public int? InsertStudentSD()
        {
            using (var conn = dapperHelper.GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                List<Student> list = new List<Student>();
                for (int i = 0; i < 3; i++)
                {
                    Student student = new Student
                    {
                        Name = "World" + i.ToString(),
                        Age = 18,
                        Gender = "male"
                    };
                    list.Add(student);
                }
                return conn.Execute(strSql, list);
            }
        }

        public IEnumerable<Student> GetStudentList1()
        {
            string strSql = "SELECT * FROM Student";
            using (var conn = dapperHelper.GetCon())
            {
                conn.Open();
                return conn.Query<Student>(strSql);
            }
        }
    }
}
