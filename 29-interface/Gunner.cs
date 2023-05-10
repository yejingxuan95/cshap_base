using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_interface
{
    class Gunner
    {
        private IFireable fireable;
        public Gunner(IFireable fireable)
        {
            this.fireable = fireable;
        }
        public void Fire()
        {
            fireable.Fire();
        }
        public void MultiFire()
        {
            fireable.MultiFire();
        }
    }
}
