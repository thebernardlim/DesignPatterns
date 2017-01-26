using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before Singleton pattern : Normal way of instantiating class
            Before.Logger logger_before = new Before.Logger();

            //After Singleton pattern : Using static method to access instance of class
            After.Logger logger_after = After.Logger.GetLogger(2);
            Console.WriteLine("First After: " + logger_after.GetCount());
            
            //Testing if the same instance is called
            After.Logger logger_after1 = After.Logger.GetLogger(5);
            Console.WriteLine("Second After: " + logger_after1.GetCount());

            Console.ReadLine();

        }
    }
}
