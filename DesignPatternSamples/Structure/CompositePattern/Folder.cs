namespace DesignPatternSamples.Structure.CompositePattern
{
    public class Folder : IComponent
    {
        private readonly List<IComponent> _children;
        private string _name;

        public Folder(string name)
        {
            _name = name;
            _children = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public string GetName()
        {
            return _name;
        }

        public void Print(int level)
        {
            Console.WriteLine($"{new string('-', level * 2)}{_name}");
            foreach (var child in _children)
            {
                child.Print(level + 1);
            }
        }
    }
}