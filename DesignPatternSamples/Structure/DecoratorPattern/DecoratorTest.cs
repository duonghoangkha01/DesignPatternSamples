namespace DesignPatternSamples.Structure.DecoratorPattern
{
    public class DecoratorTest
    {
        public static void Test()
        {
            IComponent simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            simple.Operation();
            Console.WriteLine("-------------------------------------");

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            IComponent decorator1 = new ConcreteDecoratorA(simple);
            IComponent decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            decorator2.Operation();
        }
    }
}