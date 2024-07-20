using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern.Factories
{
    // Define the abstract factory for GUI components
    public interface GUIFactory
    {
        public IButton CreateButton();

        public ILabel CreateLabel();
    }
}