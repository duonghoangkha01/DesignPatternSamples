namespace DesignPatternSamples.Creation.FactoryPattern
{
    public class FactoryTest
    {
        public static void Test()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ProductFactory1());

            Console.WriteLine();

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ProductFactory2());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public static void ClientCode(ProductFactory creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class, " +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }
}