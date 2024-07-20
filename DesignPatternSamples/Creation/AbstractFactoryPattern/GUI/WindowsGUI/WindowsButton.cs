namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.WindowsGUI
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows button");
        }

        public void Click()
        {
            Console.WriteLine("Windows button clicked");
        }
    }
}