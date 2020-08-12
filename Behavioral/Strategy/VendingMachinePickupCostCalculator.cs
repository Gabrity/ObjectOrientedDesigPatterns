namespace Strategy
{
    public class VendingMachinePickupCostCalculator : IDeliveryCostCalculator
    {
        public const double VendingMachineReducedPrice = 0.0;
        public const double VendingMachineStandardPrice = 7.0;

        public double Cost(IOrder order)
        {
            return order.OrderCost > 50.0 ? VendingMachineReducedPrice : VendingMachineStandardPrice;
        }
    }
}