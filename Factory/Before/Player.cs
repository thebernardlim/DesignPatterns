using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Before
{
    public abstract class Player
    {
        private string position;

        public Player(string position)
        {
            this.position = position;
        }

        public void PassBall() { Console.WriteLine(position + " player passed the ball");  }
        public void Shoot() { Console.WriteLine(position + " player shot at goal"); }
    }
}
