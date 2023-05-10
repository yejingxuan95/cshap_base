using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interface
{
    class Driver
    {
        private IRunnable irunnable = null;
        public Driver(IRunnable runnable)
        {
            irunnable = runnable;
        }
        public void DriverRun() {
            irunnable.Run();
        }
    }
}
