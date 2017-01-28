using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GameFactoryEnglish : GameFactoryAbstract
    {
        public override PlayerAbstract CreatePlayer()
        {
            return new PlayerEnglish();
        }

        public override ManagerAbstract CreateManager()
        {
            return new ManagerEnglish();
        }
    }
}
