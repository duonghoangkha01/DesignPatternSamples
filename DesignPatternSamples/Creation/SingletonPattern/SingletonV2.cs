namespace DesignPatternSamples.Creation.SingletonPattern
{
    /// <summary>
    /// Singleton Pattern Implementation V2 - Thread-safe with lock
    /// This implementation uses a lock to ensure thread safety but has performance implications.
    /// </summary>
    /// <remarks>
    /// Features of this implementation:
    /// - Thread-safe: Uses lock to prevent race conditions
    /// - Performance cost: Lock is acquired on every access
    /// - Lazy initialization: Instance is created only when first accessed
    /// - Simple and straightforward approach
    /// </remarks>
    public sealed class SingletonV2
    {
        private static SingletonV2? _instance;
        private static readonly object _lock = new object();

        /// <summary>
        /// Private constructor prevents external instantiation
        /// </summary>
        private SingletonV2()
        {
            Console.WriteLine("Constructor invoked.");
        }

        /// <summary>
        /// Gets the singleton instance. Creates the instance if it doesn't exist.
        /// Thread-safe implementation using lock mechanism.
        /// </summary>
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