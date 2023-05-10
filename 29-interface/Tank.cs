using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interface
{
    abstract class Tank : IFireable, IRunnable
    {
        abstract public void Fire();

        abstract public void MultiFire();
        
        abstract public void Run();
        
    }

    class SuperTank : Tank
    {
        public override void Fire()
        {
            Console.WriteLine("SuperTank Fire");
        }

        public override void MultiFire()
        {
            Console.WriteLine("SuperTank MultiFire");
        }

        public override void Run()
        {
            Console.WriteLine("SuperTank Run");
        }
    }
    class HeavyTank : Tank
    {
        public override void Fire()
        {
            Console.WriteLine("HeavyTank Fire");
        }

        public override void MultiFire()
        {
            Console.WriteLine("HeavyTank MultiFire");
        }

        public override void Run()
        {
            Console.WriteLine("HeavyTank Run");
        }
    }
}
