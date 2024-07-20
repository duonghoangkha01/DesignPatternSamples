using DesignPatternSamples.Creation.AbstractFactoryPattern.Factories;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.LinuxGUI
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