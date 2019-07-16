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
            var michael = new SalesManager("Michael", 2.0);
            var jim = new SalesManager("Jim", 5.0);
            var stanley = new SalesWorker("Stanley", 19.0);
            var ryan = new SalesWorker("Ryan", 4.0);
            var dwight = new SalesManager("Dwight", 72.0);

            michael.Add(jim);
            michael.Add(stanley);
            //stanley.Add(ryan); -invalid operation
            michael.Remove(stanley);
            michael.Add(dwight);
            jim.Add(stanley);
            jim.Add(ryan);

            WriteStatistics(michael);
            Console.ReadKey();
        }

        private static void WriteStatistics(IEmployee employee)
        {
            Console.WriteLine($"Employee called {employee.Name()} made {employee.SalesMade()} sales");
        }
    }
}
