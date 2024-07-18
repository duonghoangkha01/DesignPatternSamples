using Microsoft.EntityFrameworkCore;

namespace DesignPatternSamples.DataAccess
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}