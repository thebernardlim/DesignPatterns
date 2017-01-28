using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ManagerJap : ManagerAbstract
    {
        public override void SaysShoot()
        {
            Console.WriteLine("Jap Manager says 'Shoot!!!' ");
        }
    }
}
