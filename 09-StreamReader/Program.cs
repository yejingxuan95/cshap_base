using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamReader sr = new StreamReader(@"C:\Users\11432\Desktop\new1.txt",Encoding.Default)) {
            //    while (!sr.EndOfStream) { 
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

            using (StreamWriter sw = new StreamWriter(@"C:\Users\11432\Desktop\new1111.txt",true))
            {
                sw.Write("覆盖");
            }
            Console.ReadKey();

        }
    }
}
