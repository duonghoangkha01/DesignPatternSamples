namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Not quite as lazy, but thread-safe without using locks
    // Static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain
    public sealed class SingletonV4
    {
        private static readonly SingletonV4 _instance = new SingletonV4();

        static SingletonV4()
        {
        }

        private SingletonV4()
        {
            Console.WriteLine("Contructor invoked.");
        }

        public static SingletonV4 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return _instance;
            }
        }
    }
}