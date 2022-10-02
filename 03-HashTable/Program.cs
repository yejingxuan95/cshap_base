using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "中国";
            Console.WriteLine(name[1]);
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1,1);
            hashtable.Add("1",1);
            hashtable.Add(false,"错误");
            hashtable[7] = "中国";
            hashtable[1] = "中国1";
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine($"{item},{hashtable[item]}");
            }
            Console.ReadKey();
        }
    }
}
