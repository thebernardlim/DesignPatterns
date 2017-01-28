using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private PlayerAbstract player;
        private ManagerAbstract manager;

        // Constructor
        public Client(GameFactoryAbstract factory)
        {
            manager = factory.CreateManager();
            player = factory.CreatePlayer();
        }

        public void Run()
        {
            manager.SaysShoot();
            player.Shoot();
        }

    }
}
