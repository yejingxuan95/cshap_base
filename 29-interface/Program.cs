using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperTank superTank = new SuperTank();
            HeavyTank heavyTank = new HeavyTank();
            Driver driver = new Driver(heavyTank);
            Gunner gunner = new Gunner(heavyTank);
            gunner.Fire();
            gunner.MultiFire();
            driver.DriverRun();
            Console.ReadLine();
        }
    }
}
