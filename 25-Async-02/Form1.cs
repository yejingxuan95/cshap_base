using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_Async_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            long result1 = Calculate(100l);
            long result2 = Calculate(100000000l);
            //运行程序
            stopWatch.Stop();

            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("程序花费时间：{0}秒,{1}毫秒", t.TotalSeconds, t.TotalMilliseconds);
            Console.WriteLine($"结果1：{result1}");
            Console.WriteLine($"====================");
            Console.WriteLine($"结果2：{result2}");
        }
        static long Calculate(long start)
        {
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
        private async void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //运行程序
            Task<long> result1 = CalculateAsync(100l);
            Task<long> result2 = CalculateAsync(1000);
            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("程序花费时间：{0}秒,{1}毫秒", t.TotalSeconds, t.TotalMilliseconds);
            Console.WriteLine($"结果1：{result1.Result}");
            Console.WriteLine($"====================");
            //Console.WriteLine($"结果2：{result2.Result}");
        }

        static async Task<long> CalculateAsync(long start)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var result=0l;
            try
            {
                //运行程序
                result = await Task.Run(() => {
                    long sum = 0;
                    for (long i = start; i < 9000000000; i++)
                    {
                        sum += i;
                    }
                    return sum;
                }).ConfigureAwait(false);
            }
            catch (Exception ex)
            {

            Console.WriteLine($"{ex.Message}");

            }

            //运行程序
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            Console.WriteLine("方法运行时间：{0}秒", t.TotalSeconds);
            return result;
        }
    }
}
