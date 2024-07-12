namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Attempted thread-safety using double-check locking
    // Thread-safe without the necessity of taking out a lock every time
    public sealed class SingletonV3
    {
        private static SingletonV3? _instance;
        private static readonly object _lock = new object();

        private SingletonV3()
        {
            Console.WriteLine("Contructor invoked.");
        }

        public static SingletonV3 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new SingletonV3();
                    }
                }
                return _instance;
            }
        }
    }
}