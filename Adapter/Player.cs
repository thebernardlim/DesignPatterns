using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Player : Character
    {
        public void Pass()
        {
            Console.WriteLine("Player passes ball");
        }

        public void Shoot()
        {
            Console.WriteLine("Player shoots");
        }

    }
}
