using System;

namespace Composite
{
    public class SalesWorker : IEmployee
    {
        private readonly string _name;
        private readonly double _salesMade;
        public string Name()
        {
            return _name;
        }

        public double SalesMade()
        {
            var message = string.Concat("Calculating sales for ", Name());
            Console.WriteLine(message);
            return _salesMade;
        }

        public SalesWorker(string name, double salesMade)
        {
            _name = name;
            _salesMade = salesMade;
        }

        public void Add(IEmployee employee)
        {
            throw new NotSupportedException();
        }

        public void Remove(IEmployee employee)
        {
            throw new NotSupportedException();
        }
    }
}