namespace DesignPatternSamples.Structure.FacadePattern
{
    public class FacadeTest
    {
        public static void Test()
        {
            // Usage
            var order = new Order { Product = "T-Shirt", Quantity = 2, CustomerEmail = "customer@email.com" };

            var facade = new OrderProcessingFacade(new PaymentService(), new InventoryService(), new ShippingService());
            facade.PlaceOrder(order);
        }
    }
}