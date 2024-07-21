namespace DesignPatternSamples.Structure.ProxyPattern
{
    public class ExpensiveObjectProxy : IExpensiveObject
    {
        private readonly ExpensiveObject _realObject;
        private bool _dataRetrieved;
        private string _cachedData;

        public ExpensiveObjectProxy(ExpensiveObject realObject)
        {
            _realObject = realObject;
        }

        public string GetData()
        {
            if (!_dataRetrieved)
            {
                _cachedData = _realObject.GetData();
                _dataRetrieved = true;
            }
            return _cachedData;
        }
    }
}