namespace DesignPatternSamples.Creation.BuilderPattern
{
    /// <summary>
    /// The Builder interface specifies methods for creating the different parts
    /// of the complex object.
    /// </summary>
    public interface IBuilder
    {
        IBuilder BuildPartA();

        IBuilder BuildPartB();

        IBuilder BuildPartC();
    }
}