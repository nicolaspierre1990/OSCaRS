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
using OSCaRS.Interfaces.Context;

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

        //[HttpGet("{id}", Name = "GetProduct")]
        //public IActionResult GetById(Guid id)
        //{
        //    //var item = TodoItems.Find(id);
        //    //if (item == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return new ObjectResult(item);
        //}

        [HttpPost]
        [ProducesResponseType(typeof(Product), 201)]
        [ProducesResponseType(typeof(Product), 400)]
        public async Task<ActionResult> AddProduct(string shortDesc, string desc, decimal basePrice)
        {
            OSCaRSModel result = await productRepository.Add(shortDesc, desc, basePrice);
            Product createdProduct = (Product)result.Entity;

            if (result != null)
            {
                if (StringExtensions.IsNotNullOrEmpty(result.ErrorMessage) && result.StatusCode == HttpStatusCode.BadRequest)
                    return BadRequest(result.ErrorMessage);
                else if (result.StatusCode == HttpStatusCode.Created)
                    return CreatedAtRoute("GetProduct", new { id = createdProduct.ID }, createdProduct);
            }

            return BadRequest();
        }

        #endregion
    }
}