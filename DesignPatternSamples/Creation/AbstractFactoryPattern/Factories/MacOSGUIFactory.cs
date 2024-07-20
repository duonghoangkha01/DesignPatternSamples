using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI;
using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.MacOSGUI;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern.Factories
{
    public class MacOSGUIFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ILabel CreateLabel()
        {
            return new MacOSLabel();
        }
    }
}