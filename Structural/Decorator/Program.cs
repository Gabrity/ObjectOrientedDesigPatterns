using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /*
     * Decorator : Attach additional responsibilities to an object dynamically. Decorators provide a flexible
     * alternative to subclassing for extending functionality.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var fullPizza = new Ham(new Cheese(new PlainPizza()));

            Console.WriteLine($"Pizza description: {fullPizza.GetDescription()}");
            Console.WriteLine($"Cost: { fullPizza.GetCost()},");
            Console.ReadKey();
        }
    }
}
