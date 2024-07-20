using DesignPatternSamples.Creation.AbstractFactoryPattern.Factories;
using DesignPatternSamples.Creation.AbstractFactoryPattern.GUI;

namespace DesignPatternSamples.Creation.AbstractFactoryPattern
{
    public class AbstractFactoryTest
    {
        public static void Test()
        {
            // Create a factory for the desired platform
            GUIFactory factory = new WindowsGUIFactory(); // Or MacOSGUIFactory, LinuxGUIFactory
            ClientCode(factory);
        }

        public static void ClientCode(GUIFactory creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class, " +
                "but it still works.");

            // Create GUI components using the factory
            IButton button = creator.CreateButton();
            button.Click();

            ILabel label = creator.CreateLabel();
            label.Text = "Hello, World!";
            label.Render();
            // ...
        }
    }

    // Usage example
}