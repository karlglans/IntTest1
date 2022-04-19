using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestProject1;
using Xunit;

namespace IntTest.Api.IntegrationTests
{
    public class BasicTests
        : IClassFixture<CustomWebApplicationFactory<Api.Startup>>
    {
        private readonly CustomWebApplicationFactory<Api.Startup> _factory;

        public BasicTests(CustomWebApplicationFactory<Api.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetJsonFromFruits()
        {
            var client = _factory.CreateClient();

            // Act http://localhost:5000/fruit
            var response = await client.GetAsync("/fruit");

            var jsonString =  await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode(); // Status Code 200-299

            var fruitList = JsonConvert.DeserializeObject<List<string>>(jsonString);

            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
            Assert.Equal(3, fruitList.Count);
        }

        [Fact]
        public async Task GetHeaderFromWeatherforecast()
        {
            var client = _factory.CreateClient();

            // Act http://localhost:5000/weatherforecast
            var response = await client.GetAsync("/weatherforecast");

            var test = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode(); // Status Code 200-299

            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
