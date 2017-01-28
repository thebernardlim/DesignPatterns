﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Before
{
    class StrikerPlayer : Player
    {
        public StrikerPlayer()
            : base("Striker")
        {
            PassBall();
            Shoot();
        }
    }
}
