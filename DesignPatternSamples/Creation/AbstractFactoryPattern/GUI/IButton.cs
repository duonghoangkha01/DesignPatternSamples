namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI
{
    // Define concrete GUI components for buttons
    public interface IButton : IGUIComponent
    {
        void Click();
    }
}