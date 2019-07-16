using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class SalesManager : IEmployee
    {
        private readonly string _name;
        private readonly double _salesMade;
        private readonly IList<IEmployee> _managedPeople;

        public string Name()
        {
            return _name;
        }

        public double SalesMade()
        {
            Console.WriteLine($"Calculating sales for {Name()}");
            double salesFromManagedPeople = 0.0;
            foreach (var employee in _managedPeople)
            {
                salesFromManagedPeople += employee.SalesMade();
            }
            return _salesMade + salesFromManagedPeople;
        }

        public SalesManager(string name, double salesMade)
        {
            _name = name;
            _salesMade = salesMade;
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