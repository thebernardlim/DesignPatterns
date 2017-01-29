using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Command_CancelOrder : Command
    {
        Kitchen food;
        public Command_CancelOrder(Kitchen food)
        {
            this.food = food;
        }

        public void Execute()
        {
            food.CancelPreparation();
        }
    }
}
