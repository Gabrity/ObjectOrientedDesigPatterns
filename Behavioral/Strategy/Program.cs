using System;
using System.Collections.Specialized;

namespace Strategy
{
    /*
     * Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order("Helsinki", 60, new VendingMachinePickupCostCalculator());
            WriteOrderTotalCost(order1);

            var order2 = new Order("Budapest", 19.9, new StandardShippingCalculator());
            WriteOrderTotalCost(order2);

            var order3 = new Order("Wien", 89, new ExpressShippingCostCalculator());
            WriteOrderTotalCost(order3);
           
            var order4 = new Order("Helsinki", 35, new DepoPickupCalculator());
            WriteOrderTotalCost(order4);
        }

        private static void WriteOrderTotalCost(Order order1)
        {
            Console.WriteLine($"Order price: {order1.OrderCost} \n" + 
                              $"Order price with shipping cost: {order1.GetTotalCost()} \n");
        }
    }
}
