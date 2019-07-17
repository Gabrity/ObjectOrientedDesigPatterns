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
            var fullPizza = new Ham(new Cheese(new PlainPizza()));

            Console.WriteLine($"Pizza description: {fullPizza.GetDescription()}");
            Console.WriteLine($"Cost: { fullPizza.GetCost()},");
            Console.ReadKey();
        }
    }
}
