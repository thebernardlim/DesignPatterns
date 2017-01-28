using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Before
{
    class DefenderPlayer : Player
    {
        public DefenderPlayer() 
            : base("Defender")
        {
            PassBall();
            Shoot();
        }
    }
}
