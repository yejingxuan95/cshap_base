using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单示例
            //Task<int> t = new Task<int>(() =>
            //{
            //    Console.WriteLine("任务开始工作……{0}",Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(5000);  //模拟工作过程
            //    return 2;
            //});
            //t.Start();
            //Console.WriteLine("主线程代码{0}", Thread.CurrentThread.ManagedThreadId);
            //t.ContinueWith(task =>
            //{
            //    Console.WriteLine("任务完成，完成时候的状态为：{0}，{1}", Thread.CurrentThread.ThreadState, Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine("IsCanceled={0}\tIsCompleted={1}\tIsFaulted={2},{3}",
            //                      task.IsCanceled, task.IsCompleted, task.IsFaulted,task.Result);
            //});
            //Console.WriteLine("主线程代码1");
            //Console.ReadKey();
            #endregion

            #region 方式1:使用实例方法，Start()
            //Task t1 = new Task(() => Test("Task 1", 2000));
            //t1.Start();
            //Task t2 = new Task(() => Test("Task 2", 4000));

            //t2.Start();
            //t1.Wait();
            //Task.WaitAll(t1, t2);
            #endregion

            #region 方式2：使用Task.Run()
            //Task.Run(() => Test(2000));
            #endregion
            #region 方式3，使用TaskFactory工厂方法
            //TaskFactory taskFactory = new TaskFactory();
            //taskFactory.StartNew(() => Test("Task 3", 2000));
            //Task.Factory.StartNew(() => Test("Task 4", 2000));
            ////或者
            //var t3 = Task.Factory.StartNew(() => Test("Task 5", 2000));
            //Task.WaitAll(t3);
            #endregion


            #region 测试wait
            //创建一个任务
            Task<int> task = new Task<int>(() =>
            {
                int sum = 0;
                Console.WriteLine("使用`Task`执行异步操作.");
                for (int i = 0; i < 100; i++)
                {
                    sum += i;
                }
                return sum;
            });
            //启动任务,并安排到当前任务队列线程中执行任务(System.Threading.Tasks.TaskScheduler)
            task.Start();
            Console.WriteLine("主线程执行其他处理");
            //任务完成时执行处理。
            Task cwt = task.ContinueWith(t =>
            {
                Console.WriteLine("任务完成后的执行结果：{0}", t.Result.ToString());
            });
            Console.WriteLine("task等待{0},{1}", task.Status, cwt.Status);
            task.Wait();
            Console.WriteLine("cwt等待{0},{1}", task.Status, cwt.Status);
            cwt.Wait();
            Console.WriteLine("cwt等待{0},{1}", task.Status, cwt.Status);
            Console.Read();
            #endregion
            #region 测试waitAny



            Action<string, int> log = (name, time) =>
            {
                Console.WriteLine($"{name}任务开始...");
                Thread.Sleep(time);
                Console.WriteLine($"{name}任务结束!");
            };
            List<Task> tasks = new List<Task>
            {
                Task.Run(() => log("张三",3000)),
                Task.Run(() => log("李四",1000)),
                Task.Run(() => log("王五",2000))
            };
            //以下语句逐个测试效果
            //Task.WaitAny(tasks.ToArray());
            //Task.WaitAll(tasks.ToArray());
            //Task.WhenAny(tasks.ToArray()).ContinueWith(x => Console.WriteLine("某个Task执行完毕"));
            //Task.WhenAll(tasks.ToArray()).ContinueWith(x => Console.WriteLine("所有Task执行完毕"));
            Task.Factory.ContinueWhenAny(tasks.ToArray(), x => Console.WriteLine("某个Task执行完毕"));
            //Task.Factory.ContinueWhenAll(tasks.ToArray(), x => Console.WriteLine("所有Task执行完毕"));
            Console.WriteLine("主线程结束");
            Console.Read();
            #endregion

            //Console.ReadKey();
        }
        private static void Test(string name,int time) {
            Console.WriteLine("{0}线程任务开始执行{1},{2}", name,Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState);
            Thread.Sleep(time);
            Console.WriteLine("{0}线程任务执行完成{1}",name,Thread.CurrentThread.ManagedThreadId);
        }
    }
}
