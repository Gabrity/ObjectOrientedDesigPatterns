namespace Strategy
{
    public class Order : IOrder
    {
        private readonly IDeliveryCostCalculator _deliveryCostCalculator;

        public string City { get; }
        public double OrderCost { get; }

        public Order(string city, double orderCost, IDeliveryCostCalculator deliveryCostCalculator)
        {
            City = city;
            OrderCost = orderCost;
            _deliveryCostCalculator = deliveryCostCalculator;
        }

        public double GetTotalCost()
        {
            return OrderCost + _deliveryCostCalculator.Cost(this);
        }
    }
}