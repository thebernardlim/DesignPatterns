using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Before
{
    class CategoryAWithoutAddOnsTicket : Ticket
    {
        public override string GetDesc()
        {
            return "Category A Ticket without Add Ons";
        }

        public override double GetCost()
        {
            return 10.00;
        }
    }
}
