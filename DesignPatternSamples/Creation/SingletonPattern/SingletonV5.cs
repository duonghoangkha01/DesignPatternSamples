namespace DesignPatternSamples.Creation.SingletonPattern
{
    // Fully lazy instantiation
    // Instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance.
    public sealed class SingletonV5
    {
        private SingletonV5()
        {
            Console.WriteLine("Contructor invoked.");
        }

        public static SingletonV5 Instance
        {
            get
            {
                Console.WriteLine("Instance called.");
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly SingletonV5 instance = new SingletonV5();
        }
    }
}