using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.After
{
    public class Hotdog : AddOnsDecorator
    {
        public Hotdog(Ticket newTicket):base(newTicket)
        { 
        }

        public override string GetDesc()
        {
            return currentTicket.GetDesc() + ", Hotdog";
        }

        public override double GetCost()
        {
            return currentTicket.GetCost() + 5.00;
        }
    }
}
