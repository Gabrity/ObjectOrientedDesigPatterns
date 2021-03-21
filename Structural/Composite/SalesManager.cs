using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class SalesManager : IEmployee
    {
        private readonly SalesWorker _salesWorker;
        private readonly IList<IEmployee> _managedPeople;

        public string Name()
        {
            return _salesWorker.Name();
        }

        public double SalesMade()
        {
            Console.WriteLine($"Calculating sales for {Name()}");
            double salesFromManagedPeople = 0.0;
            foreach (var employee in _managedPeople)
            {
                salesFromManagedPeople += employee.SalesMade();
            }
            return _salesWorker.SalesMade() + salesFromManagedPeople;
        }

        public SalesManager(SalesWorker salesWorker)
        {
            _salesWorker = salesWorker;
            _managedPeople = new List<IEmployee>();
        }

        public void Add(IEmployee employee)
        {
            _managedPeople.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            _managedPeople.Remove(employee);
        }
    }
}