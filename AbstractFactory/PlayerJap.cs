using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PlayerJap : PlayerAbstract
    {
        public override void Shoot()
        {
            Console.WriteLine("Jap Player Shoots");
        }

    }
}
