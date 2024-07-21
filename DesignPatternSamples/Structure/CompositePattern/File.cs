namespace DesignPatternSamples.Structure.CompositePattern
{
    public class File : IComponent
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException("Files cannot have child components");
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException("Files cannot have child components");
        }

        public string GetName()
        {
            return _name;
        }

        public void Print(int level)
        {
            Console.WriteLine($"{new string('-', level * 2)}{_name}");
        }
    }
}