namespace Strategy
{
    public interface IOrder
    {
        string City { get; }
        double OrderCost { get; }
        double GetTotalCost();
    }
}