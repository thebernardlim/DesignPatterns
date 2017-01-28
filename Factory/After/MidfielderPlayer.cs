using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.After
{
    class MidfielderPlayer : Player
    {
        public MidfielderPlayer()
            : base("Midfielder")
        {
            PassBall();
            Shoot();
        }
    }
}
