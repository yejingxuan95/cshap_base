using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listStr = new List<string>();
            listStr.Add("aaaa");
            listStr.Add("bbb");
            listStr.Add("aaaccca");

            listStr.AddRange(new string[] { "111", "中国" });
            for (int i = 0; i < listStr.Count; i++)
            {
                Console.WriteLine(listStr[i]);
            }
            string[] strArr = listStr.ToArray();

            Console.ReadKey();

        }
    }
}
