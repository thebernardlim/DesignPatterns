using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class Player
    {
        //Template method
        public void PlayRole()
        {
            Run();
            if (PlayerHasNoBall()) Defend();
            if (PlayerHasPassOption()) Pass();
            if (PlayerHasShootOption()) Shoot();
        }

        //Hook method - Subclasses can either override or leave as original
        public virtual void Run()
        {
            Console.WriteLine("Player running..");
        }

        //Must-implement abstract methods
        public abstract void Defend();
        public abstract void Pass();
        public abstract void Shoot();

        bool PlayerHasNoBall()
        {
            Random rand = new Random();
            return Convert.ToBoolean(rand.Next(2));
        }

        bool PlayerHasPassOption()
        {
            Random rand = new Random();
            return Convert.ToBoolean(rand.Next(2));
        }

        bool PlayerHasShootOption()
        {
            Random rand = new Random();
            return Convert.ToBoolean(rand.Next(2));
        }


    }
}
