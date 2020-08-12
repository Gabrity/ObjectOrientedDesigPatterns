namespace Strategy
{
    public class DepoPickupCalculator : IDeliveryCostCalculator
    {
        public const double DepoPickupPrice = 0.0;

        public double Cost(IOrder order)
        {
            return DepoPickupPrice;
        }
    }
}