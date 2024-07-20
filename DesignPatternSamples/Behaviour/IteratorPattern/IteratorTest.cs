namespace DesignPatternSamples.Behaviour.IteratorPattern
{
    public class IteratorTest
    {
        public static void Test()
        {
            // Usage
            StringList list = new StringList();
            list.Add("Item 1");
            list.Add("Item 2");
            list.Add("Item 3");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}