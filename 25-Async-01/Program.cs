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
            Task<long> result1 = CalculateAsync(100l);
            Task<long> result2 = CalculateAsync(100000000l);
            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("程序花费时间：{0}秒,{1}毫秒", t.TotalSeconds, t.TotalMilliseconds);
            Console.WriteLine($"结果1：{result1.Result}");
            Console.WriteLine($"====================");
            Console.WriteLine($"结果2：{result2.Result}");
            Console.ReadLine();
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
        static async Task<long> CalculateAsync(long start)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            var result = await Task.Run(() => {
                long sum = 0;
                for (long i = start; i < 1000000000; i++)
                {
                    sum += i;
                }
                return sum;
            });
            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("方法运行时间：{0}秒", t.TotalSeconds);
            return result;
        }
    }
}
