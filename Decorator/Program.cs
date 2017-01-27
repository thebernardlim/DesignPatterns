using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            After.Ticket catATicketOnly = new After.CategoryATicket();
            Console.WriteLine(catATicketOnly.GetDesc() + ", " + catATicketOnly.GetCost());

            After.Ticket catATicketWithPopcornOnly = new After.Popcorn(catATicketOnly);
            Console.WriteLine(catATicketWithPopcornOnly.GetDesc() + ", " + catATicketWithPopcornOnly.GetCost());

            After.Ticket catATicketWithPopcornHotdog = new After.Popcorn(new After.Hotdog(new After.CategoryATicket()));
            After.Ticket catATicketWithHotdogOnly = new After.Hotdog(new After.CategoryATicket());

            Console.WriteLine(catATicketWithPopcornHotdog.GetDesc() + ", " + catATicketWithPopcornHotdog.GetCost());
            Console.WriteLine(catATicketWithHotdogOnly.GetDesc() + ", " + catATicketWithHotdogOnly.GetCost());
            

            Console.ReadLine();
        }
    }
}
