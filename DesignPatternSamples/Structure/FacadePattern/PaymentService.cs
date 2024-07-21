namespace DesignPatternSamples.Structure.FacadePattern
{
    public class PaymentService
    {
        public bool ProcessPayment(Order order)
        {
            Console.WriteLine($"Simulating payment processing for order: {order.Product}");
            // Simulate payment logic (replace with actual payment processing)
            return true;
        }
    }
}