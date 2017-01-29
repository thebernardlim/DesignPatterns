using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.After
{
    class Kitchen_Cook : Kitchen
    {
        public void Prepare()
        {
            Console.WriteLine("Food is cooking");
        }


        public void CancelPreparation()
        {
            Console.WriteLine("Food stopped cooking");
        }
    }
}
