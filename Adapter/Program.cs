using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //'Program' class here knows only about 'Character' interface.
            //First it calls 'Player' class which implements 'Character' interface
            Character player = new Player();
            player.Pass();
            
            //'Manager' is a totally separate class with different methods that 'Program' class does not know of
            //In order to call 'Manager', 'Program' calls 'ManagerAdapter' which implements 'Character'
            //'ManagerAdapter' will take role of an adapter and translate requests from 'Program' to 'Manager' class.
            Character managerAdapter = new ManagerAdapter();
            managerAdapter.Shoot();

            player.Shoot();

            Console.ReadLine();
        }
    }
}
