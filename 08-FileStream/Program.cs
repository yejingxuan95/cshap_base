using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream  Read 读取
            //FileStream fileStream = new FileStream(@"C:\Users\11432\Desktop\new1.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int length = fileStream.Read(buffer, 0, buffer.Length);
            //string s = Encoding.Default.GetString(buffer,0,length);
            //Console.WriteLine(s);
            //fileStream.Close();
            //fileStream.Dispose();

            //写
            //using (FileStream fswrite = new FileStream(@"C:\Users\11432\Desktop\new1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)) {
            //    string contents = "国庆阅兵仪式";
            //    byte[] buffer = Encoding.Default.GetBytes(contents);

            //    fswrite.Write(buffer,0,buffer.Length);
            //}

            using (FileStream fsRead = new FileStream(@"C:\Users\11432\Desktop\modbus-video\12.flv", FileMode.Open, FileAccess.Read)) {
                using (FileStream fsWrite = new FileStream(@"C:\Users\11432\Desktop\122.flv", FileMode.OpenOrCreate, FileAccess.Write)) {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    while (!(fsRead.Read(buffer, 0, buffer.Length) == -1)) {
                        fsWrite.Write(buffer, 0, buffer.Length);
                    }
                }
            }



                Console.ReadKey();

        }
    }
}
