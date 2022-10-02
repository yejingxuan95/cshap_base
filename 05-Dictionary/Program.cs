using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"国庆");
            
            dict[2] = "国庆你好";
            foreach (KeyValuePair<int,string> item in dict)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item},{dict[item]}");
            }
        }
    }
}
