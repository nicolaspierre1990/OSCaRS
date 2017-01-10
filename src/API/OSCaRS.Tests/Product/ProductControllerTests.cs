using Newtonsoft.Json;
using OSCaRS.Core.Models.ControllerViewModels;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OSCaRS.Tests.Product
{
    public class ProductControllerTests : TestBase
    {
        [Fact]
        public async Task AddProductSuccesFull()
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(client.BaseAddress + PRODUCT_CONTROLLER_BASE),
                Method = HttpMethod.Post,
                Content = new StringContent(
                JsonConvert.SerializeObject(new AddProductViewModel() { ShortDesc = "COLA", Description = "Coca Cola", BasePrice = 1.8M }), Encoding.UTF8, JSON_MEDIA_TYPE)
            };

            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                Assert.Equal(response.StatusCode, HttpStatusCode.Created);
            }
        }
    }
}
