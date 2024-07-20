using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI;
using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.WindowsGUI;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern.Factories
{
    // Define concrete GUI component factories for different platforms
    public class WindowsGUIFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ILabel CreateLabel()
        {
            return new WindowsLabel();
        }
    }
}