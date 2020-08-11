namespace TemplateMethod
{
    /*
     * Define the skeleton of an algorithm in an operation, deferring some steps to
     * subclasses. Template Method lets subclasses redefine certain steps of an algorithm
     * without changing the algorithm's structure.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var budgetCarManufacturer = new BudgetCarManufacturer();
            budgetCarManufacturer.ManufactureCar();

            var expensiveCarManufacturer = new ExpensiveCarManufacturer();
            expensiveCarManufacturer.ManufactureCar();
        }
    }
}
