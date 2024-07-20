namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.WindowsGUI
{
    public class WindowsLabel : ILabel
    {
        public string Text { get; set; }

        public void Render()
        {
            Console.WriteLine($"Rendering Windows label: {Text}");
        }
    }
}