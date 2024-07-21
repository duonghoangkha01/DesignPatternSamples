namespace DesignPatternSamples.Structure.CompositePattern
{
    public interface IComponent
    {
        void Add(IComponent component);

        void Remove(IComponent component);

        string GetName();

        void Print(int level); // Example operation
    }
}