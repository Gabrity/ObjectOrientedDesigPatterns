namespace Strategy
{
    public class ExpressShippingCostCalculator : IDeliveryCostCalculator
    {
        public const double ExpressShippingPrice = 15.0;

        public double Cost(IOrder order)
        {
            return ExpressShippingPrice;
        }
    }
}