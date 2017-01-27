using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Subject
    {
        void Register(Observer o);
        void Unregister(Observer o);
        void NotifyObservers();
    }
}
