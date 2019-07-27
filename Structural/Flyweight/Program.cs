using System;

namespace Flyweight
{
    /*
    * Flyweight: Use sharing to support large numbers of fine-grained objects efficiently.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Build a sushi order using patron's input
            Console.WriteLine("Please enter your sushi order (use characters T, S, C with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SushiFactory factory = new SushiFactory();

            int orderTotal = 0;

            //Get the sushi from the factory
            foreach (char c in chars)
            {
                ISushi sushi = factory.GetSushi(c);
                if (sushi != null)
                {
                    orderTotal++;
                    sushi.Display(orderTotal);
                }
            }

            Console.ReadKey();
        }
    }
}
