namespace DesignPatternSamples.Creation.FactoryPattern
{
    // Concrete Products provide various implementations of the Product
    // interface.
    public class Product1 : IProduct
    {
        public string Operation()
        {
            return "Operation in Product1";
        }
    }
}