using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.After
{
    class CategoryATicket : Ticket
    {
        public string GetDesc()
        {
            return "Category A Ticket";
        }

        public double GetCost()
        {
            return 10.00;
        }
    }
}
