namespace DesignPatternSamples.Behaviour.IteratorPattern
{
    public interface IEnumerator
    {
        bool MoveNext();

        object Current { get; }
    }
}