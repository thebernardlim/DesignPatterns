using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreGrabber scoreGrabber = new ScoreGrabber();
            ScoreObserver scoreObserver1 = new ScoreObserver(scoreGrabber);
            ScoreObserver scoreObserver2 = new ScoreObserver(scoreGrabber);
            ScoreObserver scoreObserver3 = new ScoreObserver(scoreGrabber);

            scoreGrabber.SetNewScore(1);

            scoreObserver1.PrintScore();
            scoreObserver2.PrintScore();
            scoreObserver3.PrintScore();

            scoreGrabber.Unregister(scoreObserver2);

            scoreGrabber.SetNewScore(1);

            scoreObserver1.PrintScore();
            scoreObserver2.PrintScore();
            scoreObserver3.PrintScore();

            Console.ReadLine();
        }
    }
}
