using Http.QueryString.Factories;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.IntegrationTests.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PrimeNumbers.IntegrationTests
{
    public class CheckIsPrimeNumbersTests
        : IClassFixture<PrimeNumbersWebApplicationFactory<PrimeNumbers.API.Startup>>
    {
        private readonly HttpClient _client;
        private readonly QueryStringFactory _queryStringFactory;

        public CheckIsPrimeNumbersTests(PrimeNumbersWebApplicationFactory<PrimeNumbers.API.Startup> factory)
        {
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            _queryStringFactory = new QueryStringFactory();
        }

        [Theory]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public async Task Check_Is_Prime_Number(int number, bool isPrimerNumber)
        {
            var request = new CheckIsPrimeNumberRequest
            {
                Number = number
            };

            var queryString = _queryStringFactory.Create(request);

            var result = await _client.GetAsync($"api/prime-numbers/check{queryString}");

            var content = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<CheckIsPrimeResponse>(content);

            Assert.Equal(isPrimerNumber, response.IsPrime);
        }
    }
}