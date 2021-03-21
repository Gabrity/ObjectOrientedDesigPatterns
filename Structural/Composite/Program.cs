using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /*
     * Composite: Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var michaelWorker = new SalesWorker("Michael", 2.0);
            var michaelManager = new SalesManager(michaelWorker);
            var jimWorker = new SalesWorker("Jim", 5.0);
            var jimManager = new SalesManager(jimWorker);
            var stanley = new SalesWorker("Stanley", 19.0);
            var ryan = new SalesWorker("Ryan", 4.0);
            var dwightWorker = new SalesWorker("Dwight", 72.0);
            var dwightManager = new SalesManager(dwightWorker);

            michaelManager.Add(jimManager);
            michaelManager.Add(stanley);
            //stanley.Add(ryan); -invalid operation
            michaelManager.Remove(stanley);
            michaelManager.Add(dwightManager);
            jimManager.Add(stanley);
            jimManager.Add(ryan);

            WriteStatistics(michaelManager);
            Console.ReadKey();
        }

        private static void WriteStatistics(IEmployee employee)
        {
            Console.WriteLine($"Employee called {employee.Name()} made {employee.SalesMade()} sales");
        }
    }
}
