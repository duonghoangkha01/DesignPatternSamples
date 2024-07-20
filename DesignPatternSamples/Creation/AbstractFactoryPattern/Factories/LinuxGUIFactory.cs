using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI;
using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.LinuxGUI;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern.Factories
{
    public class LinuxGUIFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ILabel CreateLabel()
        {
            return new LinuxLabel();
        }
    }

    // Usage example
}