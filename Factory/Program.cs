using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutFactoryPattern();
            WithFactoryPattern();
        }

        static void WithoutFactoryPattern(){
            string input = "";
            while (!input.Trim().Equals("Q"))
            {
                Console.WriteLine("Type 'D' for Defender, 'M' for Midfielder, 'S' for Striker, 'Q' to quit");
                input = Console.ReadLine();
                Before.Player newPlayer;
                switch (input)
                {
                    case "D":
                        newPlayer = new Before.DefenderPlayer();
                        break;
                    case "M":
                        newPlayer = new Before.MidfielderPlayer();
                        break;
                    case "S":
                        newPlayer = new Before.StrikerPlayer();
                        break;
                    default:
                        newPlayer = null;
                        break;
                }
            }
            Console.ReadLine();
        }

        static private void WithFactoryPattern(){
            string input = "";
            while (!input.Trim().Equals("Q"))
            {
                Console.WriteLine("Type 'D' for Defender, 'M' for Midfielder, 'S' for Striker, 'Q' to quit");
                input = Console.ReadLine();
                Factory.After.PlayerFactory.MakePlayer(input);
            }
            Console.ReadLine();
        }
    }
}
