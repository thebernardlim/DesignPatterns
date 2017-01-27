using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Before
{
    class CategoryAWithPopcornTicket : Ticket
    {
        public override string GetDesc()
        {
            return "Category A Ticket with Popcorn";
        }

        public override double GetCost()
        {
            return 20.00;
        }
    }
}
