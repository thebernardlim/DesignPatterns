using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class GameFacade
    {
        GameMode gameMode;
        Player currentPlayer;

        public GameFacade(GameMode gameMode, Player player)
        {
            this.gameMode = gameMode;
            currentPlayer = player;
        }

        public void PlayGame()
        {
            if (!gameMode.statePaused)
            {
                currentPlayer.Action();
            }
            else
            {
                currentPlayer.DoNothing();
            }
        }

        public void PauseGame()
        {
            gameMode.statePaused = true;
            Console.WriteLine("Game paused");
            currentPlayer.DoNothing();
        }

        public void SwitchPlayer(Player player)
        {
            currentPlayer = player;
            Console.WriteLine("Player switched");
        }
    }
}
