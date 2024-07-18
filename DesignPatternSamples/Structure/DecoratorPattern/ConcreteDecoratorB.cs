namespace DesignPatternSamples.Structure.DecoratorPattern
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("Operation in ConcreteDecoratorB");
            base.Operation();
        }
    }
}