namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI
{
    // Define concrete GUI components for labels
    public interface ILabel : IGUIComponent
    {
        string Text { get; set; }
    }
}