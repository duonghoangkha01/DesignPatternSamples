namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.MacOSGUI
{
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering macOS button");
        }

        public void Click()
        {
            Console.WriteLine("macOS button clicked");
        }
    }
}