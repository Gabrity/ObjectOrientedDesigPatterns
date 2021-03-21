namespace Decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza Pizza { get; }

        protected ToppingDecorator(IPizza pizza)
        {
            Pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return Pizza.GetCost();
        }
    }
}