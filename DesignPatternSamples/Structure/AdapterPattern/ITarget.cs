namespace DesignPatternSamples.Structure.AdapterPattern
{
    // The Target defines the domain-specific interface used by the client code. It is being used in client code
    public interface ITarget
    {
        string GetRequest();
    }
}