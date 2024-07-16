namespace DesignPatternSamples.Creation.PrototypePattern
{
    public interface IPrototype<T>
    {
        T ShallowCopy();
        T DeepCopy();
    }
}
