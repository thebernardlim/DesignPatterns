using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ManagerAdapter : Character
    {
        Manager manager;

        public ManagerAdapter()
        {
            manager = new Manager();
        }

        public void Pass(){
            manager.YellsPass();
        }

        public void Shoot()
        {
            manager.YellsShoot();
        }
    }
}
