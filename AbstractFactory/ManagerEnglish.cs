using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ManagerEnglish : ManagerAbstract
    {
        public override void SaysShoot()
        {
            Console.WriteLine("English Manager says 'Shoot!!!' ");
        }
    }
}
