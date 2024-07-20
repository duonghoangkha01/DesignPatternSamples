namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.LinuxGUI
{
    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux button");
        }

        public void Click()
        {
            Console.WriteLine("Linux button clicked");
        }
    }
}