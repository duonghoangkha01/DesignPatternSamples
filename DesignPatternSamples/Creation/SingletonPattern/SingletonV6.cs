namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Using .NET 4's Lazy<T> type
    // It's simple and performs well. It also allows you to check whether or not the instance has been created yet with the IsValueCreated property, if you need that.
    public sealed class SingletonV6
    {
        private static readonly Lazy<SingletonV6> _lazy = new Lazy<SingletonV6>(() => new SingletonV6());

        private SingletonV6()
        {
            Console.WriteLine("Contructor invoked.");
        }

        public static SingletonV6 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return _lazy.Value;
            }
        }
    }
}