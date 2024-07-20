namespace DesignPatternSamples.Structure.AdapterPattern
{
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it. It can be defined in the libraries.
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}