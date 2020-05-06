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
    public class GetNextIfNotPrimeOrCurrentTests
        : IClassFixture<PrimeNumbersWebApplicationFactory<PrimeNumbers.API.Startup>>
    {
        private readonly HttpClient _client;
        private readonly QueryStringFactory _queryStringFactory;

        public GetNextIfNotPrimeOrCurrentTests(PrimeNumbersWebApplicationFactory<PrimeNumbers.API.Startup> factory)
        {
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            _queryStringFactory = new QueryStringFactory();
        }

        [Theory]
        [InlineData("10", 11)]
        [InlineData("13", 13)]
        [InlineData("-10", 2)]
        [InlineData("123", 127)]
        public async Task Get_Next_If_Not_Prime_Or_Current_Returns_OK(string number, int outputNumber)
        {
            var request = new GetNextIfNotPrimeOrCurrentRequest
            {
                Number = number
            };

            var queryString = _queryStringFactory.Create(request);

            var result = await _client.GetAsync($"api/prime-numbers/next{queryString}");

            var content = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<GetNextIfNotPrimeOrCurrentResponse>(content);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal(outputNumber, response.Number);
        }

        [Theory]
        [InlineData("")]
        [InlineData("asd")]
        [InlineData(null)]
        public async Task Get_Next_If_Not_Prime_Or_Current_Returns_BAD_REQUEST(string number)
        {
            var request = new GetNextIfNotPrimeOrCurrentRequest
            {
                Number = number
            };

            var queryString = _queryStringFactory.Create(request);

            var result = await _client.GetAsync($"api/prime-numbers/next{queryString}");

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);            
        }
    }
}
