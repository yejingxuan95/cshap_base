using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_BeginInvoke_EndInvoke02
{

    delegate long MyDelegate(int first, int second);
    /// <summary>
    /// 轮询模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Sum);
            Console.WriteLine("调用BeginInvoke前");
            IAsyncResult ar = del.BeginInvoke(4, 5, null, null);//开始异步调用
            Console.WriteLine("调用BeginInvoke后");
            while (!ar.IsCompleted)
            {
                Console.WriteLine("异步方法还在执行");
                for (int i = 0; i < 1000000; i++)
                {

                }
            }
            Console.WriteLine("====异步方法执行完毕");
            long result = del.EndInvoke(ar);
            Console.WriteLine("运行结果:{0}", result);
        }
        static long Sum(int x,int y)
        {
            Console.WriteLine("            Sum求和方法内部");
            Thread.Sleep(50);
            return x + y;
        }
    }
}
