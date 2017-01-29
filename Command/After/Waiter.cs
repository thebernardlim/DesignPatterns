using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Waiter
    {
        Command command;

        public Waiter(Command command)
        {
            this.command = command;
        }

        public void InstructKitchen()
        {
            command.Execute();
        }

    }
}
