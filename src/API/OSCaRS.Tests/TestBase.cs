using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using OSCaRS.API;
using System.Net.Http;

namespace OSCaRS.Tests
{
    public class TestBase
    {
        public readonly string JSON_MEDIA_TYPE = "application/json";
        public readonly string PRODUCT_CONTROLLER_BASE = "api/Product";

        public TestServer server { get; }
        public HttpClient client { get; }

        public TestBase()
        {
            var builder = new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>();
            server = new TestServer(builder);
            client = server.CreateClient();
        }

        public void Dispose()
        {
            server.Dispose();
            client.Dispose();
        }
    }
}
