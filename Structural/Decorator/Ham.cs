using System;

namespace Decorator
{
    public class Ham : ToppingDecorator
    {
        public Ham(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", Ham";
        }

        public override double GetCost()
        {
            return Pizza.GetCost() + 200.0;
        }
    }
}