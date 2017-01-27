using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.After
{
    public abstract class AddOnsDecorator : Ticket
    {
        protected Ticket currentTicket;

        public AddOnsDecorator(Ticket ticket)
        {
            currentTicket = ticket;
        }

        public virtual string GetDesc()
        {
            return currentTicket.GetDesc();
        }

        public virtual double GetCost()
        {
            return currentTicket.GetCost();
        }
    }
}
