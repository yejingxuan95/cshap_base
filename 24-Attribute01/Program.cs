using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _24_Attribute01
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("你好");
        }
        static void Test(string message,[CallerFilePath] string filePath ="",[CallerLineNumber] int linenumber=0,[CallerMemberName] string memberName = "") {
            Console.WriteLine($"message:{message}");
            Console.WriteLine($"CallerFilePath:{filePath}");
            Console.WriteLine($"CallerLineNumber:{linenumber}");
            Console.WriteLine($"CallerMemberName:{memberName}");
        }
    }
}
