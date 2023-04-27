using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_BeginInvoke_EndInvoke01
{
    delegate long MyDelegate(int first, int second);
    class Program
    {
        /// <summary>
        /// 等待知道完成模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            
            MyDelegate del = new MyDelegate(Sum);
            Console.WriteLine("调用BeginInvoke前");
            IAsyncResult ar = del.BeginInvoke(4, 5, null, null);//开始异步调用
            Console.WriteLine("调用BeginInvoke后");
            long result = del.EndInvoke(ar);
            Console.WriteLine("运行结果:{0}",result);
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("程序花费时间：{0}秒,{1}毫秒",t.TotalSeconds, t.TotalMilliseconds);
            Console.ReadLine();
        }

        static long Sum(int x,int y ) 
        {
            Console.WriteLine("            Sum求和方法内部");
            Thread.Sleep(2000);
            return x + y;
        }
    }
}
