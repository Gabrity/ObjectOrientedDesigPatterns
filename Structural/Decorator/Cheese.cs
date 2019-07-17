using System;

namespace Decorator
{
    public class Cheese : ToppingDecorator
    {
        public Cheese(IPizza pizza) : base(pizza)
        {
            //Console.WriteLine("Adding doguh");
            //Console.WriteLine("Adding chesse");
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", Cheese";
        }

        public override double GetCost()
        {
            return Pizza.GetCost() + 150.0;
        }
    }
}