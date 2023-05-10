using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _27_WriteLog
{
    class LogHelper
    {
        public static void WriteTxtLog(string filePath,string message) 
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Directory.GetCurrentDirectory();
            }
            string fileName = string.Format(filePath + "\\Log\\{0:yyyy}\\{0:MM}\\{0:yyyy-MM-dd}.txt",DateTime.Now);
            FileInfo fileInfo = new FileInfo(fileName);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }
            string writeString = string.Format("{0:yyyy-MM-dd HH:mm:ss} {1}",DateTime.Now,message)+Environment.NewLine;
            File.AppendAllText(fileName,writeString);
        }

        public static void WriteCsvLog(string message) 
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log";
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            string fileName = Path.Combine(logPath, string.Format("{0:yyyy-MM-dd}.csv", DateTime.Now));
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            sw.WriteLine(DateTime.Now.ToString("HH:mm:ss:fff")+","+message+",111");
            sw.Close();
            fs.Close();
        }
    }
}
