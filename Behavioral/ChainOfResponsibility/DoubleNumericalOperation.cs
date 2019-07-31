namespace ChainOfResponsibility
{
    public class DoubleNumericalOperation : IDoubleNumericalOperation
    {
        public double First { get; }
        public double Second { get; }
        public OperationType OperationType { get; }

        public DoubleNumericalOperation(double first, double second, OperationType operationType)
        {
            First = first;
            Second = second;
            OperationType = operationType;
        }
    }
}