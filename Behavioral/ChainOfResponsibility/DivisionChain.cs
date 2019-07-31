using System;

namespace ChainOfResponsibility
{
    public class DivisionChain : ICalculatorChain
    {
        private ICalculatorChain _nextCalculatorChain;
        private OperationType _operationType => OperationType.Division;

        public void SetNextChain(ICalculatorChain nextCalculatorChain)
        {
            _nextCalculatorChain = nextCalculatorChain;
        }

        public void Calculate(IDoubleNumericalOperation numericalOperationRequest)
        {
            if (numericalOperationRequest.OperationType == _operationType)
            {
                if (numericalOperationRequest.Second == 0.0)
                {
                    throw new DivideByZeroException();
                }
                var result = numericalOperationRequest.First / numericalOperationRequest.Second;
                Console.WriteLine($"Dividing two numbers {numericalOperationRequest.First} and {numericalOperationRequest.Second}. Result is {result}.");
            }
            else
            {
                _nextCalculatorChain.Calculate(numericalOperationRequest);
            }
        }
    }
}
