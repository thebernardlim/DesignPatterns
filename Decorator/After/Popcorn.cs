using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.After
{
    public class Popcorn : AddOnsDecorator
    {
        public Popcorn(Ticket newTicket)
            : base(newTicket)
        {
        }

        public override string GetDesc()
        {
            return currentTicket.GetDesc() + ", Popcorn";
        }

        public override double GetCost()
        {
            return currentTicket.GetCost() + 10.00;
        }
    }
}
