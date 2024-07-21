namespace DesignPatternSamples.Structure.ProxyPattern
{
    public class ProxyTest
    {
        public static void Test()
        {
            IExpensiveObject expensiveObject = new ExpensiveObjectProxy(new ExpensiveObject());

            Console.WriteLine(expensiveObject.GetData()); // Triggers data retrieval
            Console.WriteLine(expensiveObject.GetData()); // Uses cached data (avoids redundant retrieval)
        }
    }
}