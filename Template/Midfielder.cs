using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Midfielder : Player
    {
        public override void Defend()
        {
            Console.WriteLine("Midfielder defending");
        }

        public override void Pass()
        {
            Console.WriteLine("Midfielder passes ball");
        }

        public override void Shoot()
        {
            Console.WriteLine("Midfielder attempts a shot");
        }
    }
}
