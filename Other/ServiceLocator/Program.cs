using System;

namespace ServiceLocator
{
    /*
     * Service Locator: a dependency injection pattern. https://martinfowler.com/articles/injection.html
     */
    class Program
    {
        static void Main(string[] args)
        {
            IServiceLocator serviceLocator = new ServiceLocator();

            // we register singleton instances to the service locator at the beginning of the program
            ICarFactory carFactory = new ElectricCarFactory();
            serviceLocator.RegisterSingletonInstance(carFactory);

            BuildCar(serviceLocator);
            Console.ReadKey();
        }

        private static void BuildCar(IServiceLocator serviceLocator)
        {
            // we can retrieve singleton instances at any point
            var carFactory = serviceLocator.ResolveSingletonInstance<ICarFactory>();
            carFactory.BuildCar();
        }
    }
}
