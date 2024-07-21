namespace DesignPatternSamples.Structure.CompositePattern
{
    public class CompositeTest
    {
        public static void Test()
        {
            // Usage
            var root = new Folder("root");
            root.Add(new File("file1.txt"));
            var subFolder = new Folder("subfolder");
            subFolder.Add(new File("file2.txt"));
            root.Add(subFolder);

            root.Print(0);
        }
    }
}