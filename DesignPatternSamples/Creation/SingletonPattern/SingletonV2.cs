namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Simple thread-safety
    // Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
    public sealed class SingletonV2
    {
        private static SingletonV2? _instance;
        private static readonly object _lock = new object();

        private SingletonV2()
        {
            Console.WriteLine("Contructor invoked.");
        }

        public static SingletonV2 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                lock (_lock)
                {
                    _instance ??= new SingletonV2();
                }
                return _instance;
            }
        }
    }
}