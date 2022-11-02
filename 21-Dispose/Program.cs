using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestDispose test = new TestDispose())
            {

            }
            Console.WriteLine("读取按键中");
            Console.ReadKey();
            
            GC.Collect();
            Console.WriteLine("读取到按键，程序结束");
            Console.ReadKey();
        }
    }
    class TestDispose:IDisposable {
        ~TestDispose() {
            Console.WriteLine("析构函数执行");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose()");
            //GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
    }
}
