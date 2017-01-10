using OSCaRS.Core.Models;
using OSCaRS.Core.Repository;
using OSCaRS.Domain.Context;
using OSCaRS.Domain.Model;
using System.Threading.Tasks;

namespace OSCaRS.Repositories.Product
{
    public class ProductRepository : Repository<OSCaRS.Domain.Model.Product>
    {
        public ProductRepository(OSCaRSContext context) : base(context)
        {
        }

        public async Task<OSCaRSModel> Add(string shortDesc, string desc, decimal basePrice)
        {
            return new OSCaRSModel("Empty Parameters", System.Net.HttpStatusCode.BadRequest);
        }
    }
}
