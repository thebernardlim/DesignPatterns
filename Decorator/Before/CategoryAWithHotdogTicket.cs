using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Before
{
    class CategoryAWithHotdogTicket : Ticket
    {
        public override string GetDesc()
        {
            return "Category A Ticket with Hotdog";
        }

        public override double GetCost()
        {
            return 15.00;
        }
    }
}
