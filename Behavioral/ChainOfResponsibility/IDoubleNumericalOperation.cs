namespace ChainOfResponsibility
{
    public interface IDoubleNumericalOperation
    {
        double First { get; }
        double Second { get; }
        OperationType OperationType { get; }
    }
}