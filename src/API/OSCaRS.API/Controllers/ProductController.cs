using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OSCaRS.Domain.Context;
using OSCaRS.Repositories.Product;
using OSCaRS.Extensions;
using OSCaRS.Core.Models;
using System.Net;
using OSCaRS.Domain.Model;

namespace OSCaRS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private ProductRepository productRepository;

        public ProductController(OSCaRSContext context)
        {
            productRepository = new ProductRepository(context);
        }

        #region Calls

        [Route("AddProduct")]
        public ActionResult AddProduct(string shortDesc, string desc, decimal basePrice)
        {
            return Ok();
        }

        #endregion
    }
}