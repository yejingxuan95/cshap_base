using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _25_Async_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            long result1 =  Calculate(100l);
            long result2 = Calculate(100000000l);
            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("程序花费时间：{0}秒,{1}毫秒", t.TotalSeconds, t.TotalMilliseconds);
            Console.WriteLine($"结果1：{result1}");
            Console.WriteLine($"====================");
            Console.WriteLine($"结果2：{result2}");
        }

        static  long  Calculate(long start) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            long sum = 0;
            for (long i = start; i < 1000000000; i++)
            {
                sum += i;
            }
            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("方法运行时间：{0}秒", t.TotalSeconds);
            return sum;
        }
        
    }
}
