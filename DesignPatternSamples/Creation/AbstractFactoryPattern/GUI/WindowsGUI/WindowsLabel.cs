namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.WindowsGUI
{
    public class WindowsLabel : ILabel
    {
        public string Text { get; set; } = string.Empty;

        public void Render()
        {
            Console.WriteLine($"Rendering Windows label: {Text}");
        }
    }
}