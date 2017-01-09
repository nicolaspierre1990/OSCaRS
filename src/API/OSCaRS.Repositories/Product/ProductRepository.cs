using OSCaRS.Core.Repository;
using OSCaRS.Domain.Context;

namespace OSCaRS.Repositories.Product
{
    public class ProductRepository : Repository<OSCaRS.Domain.Product>
    {
        public ProductRepository(OSCaRSContext context) : base(context)
        {
        }
    }
}
