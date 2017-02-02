using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Midfielder : Player
    {
        public void Action()
        {
            Console.WriteLine("Midfielder starts to look to pass");
        }

        public void DoNothing()
        {
            Console.WriteLine("Midfielder does nothing");
        }
    }
}
