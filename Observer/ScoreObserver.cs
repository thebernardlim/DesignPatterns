using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ScoreObserver : Observer
    {
        public Subject scoreGrabber;
        public static int observerIDTracker;
        private int observerID;
        private int score;

        public ScoreObserver(Subject scoreGrabber)
        {
            this.scoreGrabber = scoreGrabber;
            this.observerID = ++observerIDTracker;

            scoreGrabber.Register(this);

            Console.WriteLine("New Observer " + observerID + " created and registered");
        }

        public void UpdateScore(int score)
        {
            Console.WriteLine("Observer " + observerID + " received updated score!");
            this.score = score;
        }

        public int PrintScore()
        {
            Console.WriteLine("New Observer " + observerID + " received score as " + score);
            return score;
        }
    }
}
