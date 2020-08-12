namespace Strategy
{
    public class StandardShippingCalculator : IDeliveryCostCalculator
    {
        public const double ReducedStandardShippingPrice = 7.0;
        public const double StandardShippingPrice = 10.0;

        public double Cost(IOrder order)
        {
            return order.City == "Budapest" ? ReducedStandardShippingPrice : StandardShippingPrice;
        }
    }
}