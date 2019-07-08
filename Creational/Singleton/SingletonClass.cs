namespace Singleton
{
    internal class SingletonClass
    {
        private static SingletonClass Instance;
        private SingletonClass()
        {
        }

        public static SingletonClass GetInstance()
        {
            // lazy instantiation
            if (Instance == null)
            {
                return new SingletonClass();
            }

            return Instance;
        }
    }
}