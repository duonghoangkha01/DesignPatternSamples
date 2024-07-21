namespace DesignPatternSamples.Structure.FacadePattern
{
    public class InventoryService
    {
        public bool CheckStock(Order order)
        {
            Console.WriteLine($"Checking stock for {order.Product} (quantity: {order.Quantity})");
            // Simulate stock checking logic (replace with actual stock check)
            return true;
        }
    }
}