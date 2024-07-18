namespace DesignPatternSamples.Structure.DecoratorPattern
{
    // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void SetComponent(IComponent component)
        {
            _component = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public virtual void Operation()
        {
            Console.WriteLine("Operation in Base Decorator");
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
}