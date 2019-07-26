using System;

namespace Proxy
{
    /*
    * Proxy: Provide a surrogate or placeholder for another object to control access to it.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var imagePath = "C:\\Portraits\\John.jpg";
            var proxy = new GraphicalObjectProxy(imagePath);
            Console.WriteLine($"Picture height is: {proxy.ImageHeight()}");
            proxy.Draw();
            // second time instantiation is not needed
            Console.WriteLine($"Picture width is: {proxy.ImageWidth()}");
            Console.ReadKey();
        }
    }
}
