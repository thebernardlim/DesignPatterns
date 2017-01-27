using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Before
{
    abstract class Ticket
    {
        public abstract string GetDesc();
        public abstract double GetCost();
    }
}
