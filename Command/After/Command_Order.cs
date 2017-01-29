using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Command_Order : Command
    {
        Kitchen food;
        public Command_Order(Kitchen food)
        {
            this.food = food;
        }

        public void Execute()
        {
            food.Prepare();
        }
    }
}
