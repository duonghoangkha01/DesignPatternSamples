namespace DesignPatternSamples.Structure.FacadePattern
{
    public class OrderProcessingFacade : IOrderProcessing
    {
        private readonly PaymentService _paymentService;
        private readonly InventoryService _inventoryService;
        private readonly ShippingService _shippingService;

        public OrderProcessingFacade(PaymentService paymentService, InventoryService inventoryService, ShippingService shippingService)
        {
            _paymentService = paymentService;
            _inventoryService = inventoryService;
            _shippingService = shippingService;
        }

        public void PlaceOrder(Order order)
        {
            if (!_inventoryService.CheckStock(order))
            {
                Console.WriteLine("Order failed: Insufficient stock");
                return;
            }

            if (!_paymentService.ProcessPayment(order))
            {
                Console.WriteLine("Order failed: Payment processing failed");
                return;
            }

            _shippingService.SendOrderConfirmation(order);
            _shippingService.ShipOrder(order);

            Console.WriteLine("Order placed successfully!");
        }
    }
}