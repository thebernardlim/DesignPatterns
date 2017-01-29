using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Menu
    {
        public static Kitchen Choose(string food)
        {
            switch (food){
                case "Coffee": return new Kitchen_Barista();
                case "Noodles": return new Kitchen_Cook();
                default : return new Kitchen_Barista();
            }
        }
    }

}
