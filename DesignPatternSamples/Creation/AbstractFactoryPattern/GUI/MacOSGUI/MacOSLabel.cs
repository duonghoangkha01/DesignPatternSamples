namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.MacOSGUI
{
    public class MacOSLabel : ILabel
    {
        public string Text { get; set; }

        public void Render()
        {
            Console.WriteLine($"Rendering macOS label: {Text}");
        }
    }
}