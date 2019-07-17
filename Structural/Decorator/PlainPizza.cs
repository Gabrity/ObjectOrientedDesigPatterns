namespace Decorator
{
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Dough";
        }

        public double GetCost()
        {
            return 400.0;
        }
    }
}