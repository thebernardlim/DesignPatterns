using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After
{
    class Logger
    {
        private static Logger logger;
        private static int mainCount;
        private static readonly object _lock = new object();

        private Logger(int count) { mainCount = count; }

        public static Logger GetLogger(int count)
        {
            lock(_lock)
            {
                if (logger == null)
                {
                    logger = new Logger(count);
                }
                else
                {
                    mainCount += count;
                }
            }
            return logger;
        }

        public int GetCount()
        {
            return mainCount;
        }
    }
}
