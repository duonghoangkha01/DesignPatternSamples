namespace DesignPatternSamples.Structure.DecoratorPattern
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    internal class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operation in ConcreteComponent");
        }
    }
}