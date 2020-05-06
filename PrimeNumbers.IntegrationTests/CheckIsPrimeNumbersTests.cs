using Http.QueryString.Factories;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using PrimeNumbers.IntegrationTests.Models.Requests;
using PrimeNumbers.IntegrationTests.Models.Responses;
using System.Net;
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
        [InlineData("10", false)]
        [InlineData("11", true)]
        [InlineData("-1", false)]
        [InlineData("100003", true)]
        [InlineData("100004", false)]
        public async Task Check_Is_Prime_Number_Returns_OK(string number, bool isPrimerNumber)
        {
            var request = new CheckIsPrimeNumberRequest
            {
                Number = number
            };

            var queryString = _queryStringFactory.Create(request);

            var result = await _client.GetAsync($"api/prime-numbers/check{queryString}");

            var content = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<CheckIsPrimeNumberResponse>(content);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal(isPrimerNumber, response.IsPrime);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("asd")]
        public async Task Check_Is_Prime_Number_Returns_BAD_REQUEST(string number)
        {
            var request = new CheckIsPrimeNumberRequest
            {
                Number = number
            };

            var queryString = _queryStringFactory.Create(request);

            var result = await _client.GetAsync($"api/prime-numbers/check{queryString}");

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);            
        }
    }
}