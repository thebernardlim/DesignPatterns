using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class GameMode
    {
        bool _statePaused = false;

        public bool statePaused
        {
            get
            {
                return _statePaused;
            }
            set
            {
                _statePaused = value;
            }
        }

    }
}
