using Microsoft.AspNetCore.Mvc.Testing;

namespace PrimeNumbers.IntegrationTests
{
    public class PrimeNumbersWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
    }
}
