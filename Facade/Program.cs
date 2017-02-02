using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMode currentGameMode = new GameMode();
            Player defender = new Defender();
            Player midfielder = new Midfielder();

            GameFacade gameFacade = new GameFacade(currentGameMode, defender);
            gameFacade.PlayGame();

            gameFacade.SwitchPlayer(midfielder);
            gameFacade.PlayGame();

            gameFacade.PauseGame();

            Console.ReadLine();

        }
    }
}
