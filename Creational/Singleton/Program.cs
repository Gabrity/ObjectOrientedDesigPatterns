namespace Singleton
{
    /*
     * Singleton: Ensure a class only has one instance, and provide a global point of access to it.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // first with property initialization
            SingletonClass.GetInstance();

            // second with already initialized value
            SingletonClass.GetInstance();
        }
    }
}
