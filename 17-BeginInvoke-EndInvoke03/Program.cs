using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_BeginInvoke_EndInvoke03
{
    delegate long MyDelegate(int first, int second);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Sum);
            Console.WriteLine("调用BeginInvoke前");
            IAsyncResult iar= del.BeginInvoke(3,4,CallWhenDone,null);
            Console.WriteLine("调用BeginInvoke后");
            Console.WriteLine("main doing");
            Thread.Sleep(500);
            Console.WriteLine("main done");
        }
        static void CallWhenDone(IAsyncResult iar) {
            AsyncResult ar = (AsyncResult)iar;
            MyDelegate del = (MyDelegate) ar.AsyncDelegate;
            long result = del.EndInvoke(iar);
            Console.WriteLine("运行结果:{0}", result);
        }
        static long Sum(int x, int y) {
            Console.WriteLine("Sum方法执行");
            Thread.Sleep(100);
            return x + y;
        }
    }
}
