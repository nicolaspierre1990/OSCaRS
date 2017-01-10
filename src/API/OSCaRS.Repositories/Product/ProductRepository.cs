using OSCaRS.Core.Models;
using OSCaRS.Core.Repository;
using OSCaRS.Domain.Context;
using OSCaRS.Extensions;
using System.Net;
using System.Text;
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
            StringBuilder sb = new StringBuilder();
            OSCaRSModel result = null;

            if (string.IsNullOrEmpty(shortDesc) && shortDesc.Length > 2)
                sb.AppendLine("ShortDesc is required or needs to be longer then 2 characters");
            if (string.IsNullOrEmpty(desc) && desc.Length > 2)
                sb.AppendLine("Desc is required or needs to be longer then 2 characters");
            if(basePrice == 0)
                sb.AppendLine("BasePrice needs to be higher then 0");

            if(sb.Length == 0)
            {
                OSCaRS.Domain.Model.Product newProduct = new Domain.Model.Product()
                {
                    ShortDesc = shortDesc,
                    Description = desc,
                    BasePrice = basePrice
                };

                await this.Add(newProduct);

                result = new OSCaRSModel(string.Empty, HttpStatusCode.Created);
                result.Entity = newProduct;
            }
            else
            {
                result = new OSCaRSModel(sb.ToString(), HttpStatusCode.BadRequest);
            }

            return result;
        }
    }
}
