using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Defender : Player
    {
        public void Action()
        {
            Console.WriteLine("Defender starts defending");
        }

        public void DoNothing()
        {
            Console.WriteLine("Defender does nothing");
        }
    }
}
