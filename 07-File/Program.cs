using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件
            //File.Create(@"C:\Users\11432\Desktop\new.txt");
            //删除文件
            //File.Delete(@"C:\Users\11432\Desktop\new.txt");
            //File.Copy(@"C:\Users\11432\Desktop\new.txt",@"C:\Users\11432\Desktop\new1.txt");

            byte[] buffer = File.ReadAllBytes(@"C:\Users\11432\Desktop\new1.txt");
            string s = Encoding.Default.GetString(buffer);
            Console.WriteLine(s);


            string str = "今天国庆节111";
            byte[] bufstr = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\11432\Desktop\new1.txt",bufstr);

            //File.ReadAllLines
            string[] contents = File.ReadAllLines(@"C:\Users\11432\Desktop\new.txt");
            foreach (var item in contents)
            {
                //Console.WriteLine(item);
            }
            //File.ReadAllText
            string alltext = File.ReadAllText(@"C:\Users\11432\Desktop\new.txt");
            //Console.WriteLine(alltext);
            Console.ReadKey();

        }
    }
}
