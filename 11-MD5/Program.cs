using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _11_MD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = GetMD5("123123");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string GetMD5(string str) {
            MD5 md = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] md5Buffer = md.ComputeHash(buffer);
            string result = "";
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                result += md5Buffer[i].ToString("x2");
            }
            return result;
            //return Encoding.Default.GetString(md5Buffer); 
        }
    }
}
