using System;

namespace ChainOfResponsibility
{
    public class MultiplicationChain : ICalculatorChain
    {
        private ICalculatorChain _nextCalculatorChain;
        private OperationType _operationType => OperationType.Multiplication;

        public void SetNextChain(ICalculatorChain nextCalculatorChain)
        {
            _nextCalculatorChain = nextCalculatorChain;
        }

        public void Calculate(IDoubleNumericalOperation numericalOperationRequest)
        {
            if (numericalOperationRequest.OperationType == _operationType)
            {
                var result = numericalOperationRequest.First * numericalOperationRequest.Second;
                Console.WriteLine($"Multiplying two numbers {numericalOperationRequest.First} and {numericalOperationRequest.Second}. Result is {result}.");
            }
            else
            {
                _nextCalculatorChain.Calculate(numericalOperationRequest);
            }
        }
    }
}
