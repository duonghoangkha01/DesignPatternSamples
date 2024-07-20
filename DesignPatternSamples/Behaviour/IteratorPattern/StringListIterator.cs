namespace DesignPatternSamples.Behaviour.IteratorPattern
{
    public class StringListIterator : IEnumerator
    {
        private readonly List<string> _items;
        private int _currentIndex = -1;

        public StringListIterator(List<string> items)
        {
            _items = items;
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _items.Count;
        }

        public string Current => _items[_currentIndex];

        object IEnumerator.Current => Current;

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}