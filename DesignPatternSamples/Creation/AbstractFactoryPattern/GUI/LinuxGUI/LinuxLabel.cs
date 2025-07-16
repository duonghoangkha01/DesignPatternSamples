namespace DesignPatternSamples.Creation.AbstractFactoryPattern.GUI.LinuxGUI
{
    public class LinuxLabel : ILabel
    {
        public string Text { get; set; } = string.Empty;

        public void Render()
        {
            Console.WriteLine($"Rendering Linux label: {Text}");
        }
    }
}