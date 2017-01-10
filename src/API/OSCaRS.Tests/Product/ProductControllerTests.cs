using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using OSCaRS.API;
using OSCaRS.Repositories.Product;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace OSCaRS.Tests.Product
{
    public class ProductControllerTests
    {
        public TestServer server { get; }
        public HttpClient client { get; }

        public ProductControllerTests()
        {
            var builder = new WebHostBuilder().UseStartup<Startup>();
            server = new TestServer(builder);
            client = server.CreateClient();
        }

        [Fact]
        public async Task AddProductSuccesFull()
        {
            
        }
    }
}
