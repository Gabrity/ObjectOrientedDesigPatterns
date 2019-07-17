namespace Decorator
{
    public class ToppingDecorator : IPizza
    {
        protected readonly IPizza Pizza;

        public ToppingDecorator(IPizza pizza)
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