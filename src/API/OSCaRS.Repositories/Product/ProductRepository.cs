using OSCaRS.Core.Models;
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

        public OSCaRSModel Add(string shortDesc, string desc, decimal basePrice)
        {
            return new OSCaRSModel("Empty Parameters", System.Net.HttpStatusCode.BadRequest);
        }
    }
}
