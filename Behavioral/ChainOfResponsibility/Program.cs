using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        /*
         * Chain of Responsibility: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
         * Chain the receiving objects and pass the request along the chain until an object handles it.
         */
        static void Main(string[] args)
        {
            var additionChain = new AdditionChain();
            var substractionChain = new SubstractionChain();
            var multiplicationChain = new MultiplicationChain();
            var divisionChain = new DivisionChain();
            var endChain = new EndChain();

            additionChain.SetNextChain(substractionChain);
            substractionChain.SetNextChain(multiplicationChain);
            multiplicationChain.SetNextChain(divisionChain);
            divisionChain.SetNextChain(endChain);

            var request = new DoubleNumericalOperation(1.5, 5.5, OperationType.Division);

            additionChain.Calculate(request);

            Console.ReadKey();
        }
    }
}
