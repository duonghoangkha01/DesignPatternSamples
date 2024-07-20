namespace DesignPatternSamples.Behaviour.IteratorPattern
{
    public class StringList : IEnumerable
    {
        private readonly List<string> _items = new List<string>();

        public void Add(string item)
        {
            _items.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            return new StringListIterator(_items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}