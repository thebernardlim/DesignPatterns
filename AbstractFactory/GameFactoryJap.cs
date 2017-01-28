using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GameFactoryJap : GameFactoryAbstract
    {
        public override PlayerAbstract CreatePlayer()
        {
            return new PlayerJap();
        }

        public override ManagerAbstract CreateManager()
        {
            return new ManagerJap();
        }
    }
}
