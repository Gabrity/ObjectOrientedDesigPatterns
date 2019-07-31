using System;
using System.ComponentModel;

namespace ChainOfResponsibility
{
    public class EndChain : ICalculatorChain
    {
        public void SetNextChain(ICalculatorChain nextCalculatorChain)
        {
            return;
        }

        public void Calculate(IDoubleNumericalOperation numericalOperationRequest)
        {
            // when the chain could not handle the request, we end up here
            throw new InvalidEnumArgumentException($"Chain was unable to handle {numericalOperationRequest.OperationType}");
        }
    }
}
