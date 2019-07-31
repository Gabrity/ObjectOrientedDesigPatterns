using System;

namespace ChainOfResponsibility
{
    public interface ICalculatorChain
    {
        void SetNextChain(ICalculatorChain nextCalculatorChain);
        void Calculate(IDoubleNumericalOperation numericalOperationRequest);
    }
}
