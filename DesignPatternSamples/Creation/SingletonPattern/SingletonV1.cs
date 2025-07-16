namespace DesignPatternSamples.Creation.SingletonPattern
{
    /// <summary>
    /// Singleton Pattern Implementation V1 - Basic implementation (NOT THREAD-SAFE)
    /// This is a simple but flawed implementation that should NOT be used in multi-threaded environments.
    /// It demonstrates the basic concept but has race condition issues.
    /// </summary>
    /// <remarks>
    /// Problems with this implementation:
    /// - Not thread-safe: Multiple threads could create multiple instances
    /// - Performance: No significant performance issues in single-threaded scenarios
    /// - Lazy initialization: Instance is created only when first accessed
    /// </remarks>
    public sealed class SingletonV1
    {
        private static SingletonV1? _instance;

        /// <summary>
        /// Private constructor prevents external instantiation
        /// </summary>
        private SingletonV1()
        {
            Console.WriteLine("Constructor invoked.");
        }

        /// <summary>
        /// Gets the singleton instance. Creates the instance if it doesn't exist.
        /// WARNING: This implementation is NOT thread-safe!
        /// </summary>
        public static SingletonV1 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return _instance ??= new SingletonV1();
            }
        }
    }
}