using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.After
{
    class PlayerFactory
    {
        public static Player MakePlayer(String newPlayerType){

            switch(newPlayerType)
            {
                case "D" :
                    return new DefenderPlayer();
                case "M":
                    return new MidfielderPlayer();
                case "S":
                    return new StrikerPlayer();
                default :
                    return null;
            }
        }
    }
}
