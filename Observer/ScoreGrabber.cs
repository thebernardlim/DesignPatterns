using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ScoreGrabber : Subject
    {
        public List<Observer> observers;
        private int score;

        public ScoreGrabber()
        {
            observers = new List<Observer>();
        }

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(Observer deleteObserver)
        {
            Console.WriteLine("Observer" + (observers.IndexOf(deleteObserver) + 1) + " unregistered");
            observers.Remove(deleteObserver);
        }

        public void NotifyObservers()
        {
            foreach (Observer ob in observers)
                ob.UpdateScore(score);
        }

        public void SetNewScore(int newScore)
        {
            this.score += newScore;
            NotifyObservers();
        }
    }
}
