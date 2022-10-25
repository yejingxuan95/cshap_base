using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _16_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件拥有者
            timer.Interval = 1000;
            Boy boy = new Boy();
            //Elapsed  事件     boy 订阅   处理器为actionHandler
            timer.Elapsed += boy.ActionHandler;//用boy订阅timer的Elapsed事件,处理事件为Action方法
            Girl girl = new Girl();
            timer.Elapsed += girl.ActionHandler;
            timer.Start();
            Console.ReadKey();
        }
    }

    class Boy
    {
        internal void ActionHandler(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Boy事件响应者，执行方法");
        }
    }
    class Girl
    {
        internal void ActionHandler(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Girl事件响应者，执行方法");
        }
    }
}
