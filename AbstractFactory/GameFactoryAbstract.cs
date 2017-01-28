using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class GameFactoryAbstract
    {
        public abstract PlayerAbstract CreatePlayer();
        public abstract ManagerAbstract CreateManager();
    }
}
