using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_path
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\work\workspace\vs\c_code\01-basics-grammar\111.txt";
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"C:\","av.txt"));
            Console.ReadKey();
        }
    }
}
