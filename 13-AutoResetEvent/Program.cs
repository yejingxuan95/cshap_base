using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_AutoResetEvent
{
    class Program
    {
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("主线程，当前时间：{0}", DateTime.Now.ToShortTimeString());
            Thread thread = new Thread(Test);
            //thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(6000);
            autoResetEvent.Set();
            Console.WriteLine("主线程，当前时间：{0}", DateTime.Now.ToShortTimeString());

        }
        private static void Test() {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(200);
                if (i==10)
                {
                    Console.WriteLine("辅助线程，当前时间：{0}", DateTime.Now.ToShortTimeString());
                    autoResetEvent.WaitOne();
                }
                Console.WriteLine("线程执行中{0}",i);
            }
        }
    }
}
