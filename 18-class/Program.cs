using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_class
{
    class Program
    {
        /// <summary>
        /// 1子类静态成员        
        /// 2子类静态构造
        /// 3子类实例成员
        /// 4父类静态成员
        /// 5父类静态构造
        /// 6父类实例成员
        /// 7父类实例构造
        /// 8子类实例构造
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Sun sun = new Sun();
            Console.ReadKey();
        }
    }

    class Father {
        public static C c = new C("static  father");
        public static C c1 = new C("非  father");
        static Father(){
            Console.WriteLine("父类静态构造");
        }
        public Father() {
            Console.WriteLine("父类非静态构造");
        }
    }
    class Sun : Father {
        public static C c = new C("static Sun");
        public static C c1 = new C("非  Sun");
        //public static Sun sun = new Sun();
        static Sun() {
            Console.WriteLine("子类静态构造");
        }
        public Sun()
        {
            Console.WriteLine("子类非静态构造");
        }
    }

    class C {
        public C(string name) {
            Console.WriteLine("{0}成员进入了C的构造", name);
        }
    }
}
