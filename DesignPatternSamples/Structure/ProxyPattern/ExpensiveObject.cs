namespace DesignPatternSamples.Structure.ProxyPattern
{
    public class ExpensiveObject : IExpensiveObject
    {
        public string GetData()
        {
            Console.WriteLine("Simulating expensive data retrieval...");
            return "This is expensive data!";
        }
    }
}