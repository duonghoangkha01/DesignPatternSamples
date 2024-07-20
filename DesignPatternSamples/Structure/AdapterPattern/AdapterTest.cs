namespace DesignPatternSamples.Structure.AdapterPattern
{
    public class AdapterTest
    {
        public static void Test()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            ClientCode(target);
        }

        public static void ClientCode(ITarget target)
        {
            Console.WriteLine(target.GetRequest());
        }
    }
}