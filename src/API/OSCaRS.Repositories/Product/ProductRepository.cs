using OSCaRS.Core.Repository;
using OSCaRS.Domain.Context;
using OSCaRS.Domain.Model;

namespace OSCaRS.Repositories.Product
{
    public class ProductRepository : Repository<OSCaRS.Domain.Model.Product>
    {
        public ProductRepository(OSCaRSContext context) : base(context)
        {
        }

        public override void Add(Domain.Model.Product entity)
        {
            base.Add(entity);
        }
    }
}
