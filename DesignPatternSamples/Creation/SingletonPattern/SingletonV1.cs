namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Bad code! Do not use!
    // Not thread-safe
    public sealed class SingletonV1
    {
        private static SingletonV1? _instance;

        private SingletonV1()
        {
            Console.WriteLine("Contructor invoked.");
        }

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