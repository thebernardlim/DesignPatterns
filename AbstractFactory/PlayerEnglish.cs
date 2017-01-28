using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PlayerEnglish : PlayerAbstract
    {
        public override void Shoot()
        {
            Console.WriteLine("English Player Shoots");
        }

    }
}
