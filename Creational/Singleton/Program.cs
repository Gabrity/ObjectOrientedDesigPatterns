namespace Singleton
{
    /*
     * Singleton: Ensure a class only has one instance, and provide a global point of access to it.
     */
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.GetInstance();
        }
    }
}
