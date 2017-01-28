using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Before
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
