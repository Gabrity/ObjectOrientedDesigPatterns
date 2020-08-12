namespace Strategy
{
    public interface IDeliveryCostCalculator
    {
        double Cost(IOrder order);
    }
}