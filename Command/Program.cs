using Command.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer makes an order
            Kitchen desiredChoice = Menu.Choose("Coffee");

            //Customer wants to order that food item
            Command_Order orderCommand = new Command_Order(desiredChoice);

            //Customer instructs waiter with the order food command, so restaurant can get his food prepared
            Waiter waiter = new Waiter(orderCommand);

            //Waiter instructs kitchen whatever customer ordered - Waiter doesn't care how / where the orders get directed to within the kitchen (i.e. Cook or Barista)
            waiter.InstructKitchen();

            //Customer suddenly wants to cancel the food
            Command_CancelOrder cancelOrderCommand = new Command_CancelOrder(desiredChoice);

            //Customer instructs waiter with his command, ie. to get his food prepared
            waiter = new Waiter(cancelOrderCommand);

            //Waiter instructs kitchen whatever customer ordered  - Waiter doesn't care how / where the orders get directed to within the kitchen (i.e. Cook or Barista)
            waiter.InstructKitchen();

            Console.ReadLine();
        }
    }
}
