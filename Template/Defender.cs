using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Defender : Player
    {
        public override void Defend()
        {
            Console.WriteLine("Defender defending");
        }

        public override void Pass()
        {
            Console.WriteLine("Defender passes ball");
        }

        public override void Shoot()
        {
            Console.WriteLine("Defender attempts a shot");
        }

        public override void Run()
        {
            Console.WriteLine("Defender runs..");
        }
    }
}
