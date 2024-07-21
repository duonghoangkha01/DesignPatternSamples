namespace DesignPatternSamples.Structure.FacadePattern
{
    public class ShippingService
    {
        public void SendOrderConfirmation(Order order)
        {
            Console.WriteLine($"Sending order confirmation email to {order.CustomerEmail}");
        }

        public void ShipOrder(Order order)
        {
            Console.WriteLine($"Simulating shipping order: {order.Product}");
        }
    }
}