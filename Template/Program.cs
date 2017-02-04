using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Player defender = new Defender();
            defender.PlayRole();

            Player midfielder = new Midfielder();
            midfielder.PlayRole();

            Console.ReadLine();
        }
    }
}
