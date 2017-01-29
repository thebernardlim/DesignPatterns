using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Kitchen_Barista : Kitchen
    {
        public void Prepare()
        {
            Console.WriteLine("Coffee Prepared");
        }


        public void CancelPreparation()
        {
            Console.WriteLine("Coffee Orders Canceled");
        }
    }
}
