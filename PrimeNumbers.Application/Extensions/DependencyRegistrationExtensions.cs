using Microsoft.Extensions.DependencyInjection;
using PrimeNumbers.Application.Interfaces;
using PrimeNumbers.Application.Services;

namespace PrimeNumbers.Application.Extensions
{
    public static class DependencyRegistrationExtensions
    {
        public static IServiceCollection RegisterApplicationDependencies(this IServiceCollection services)
        {
            return services
                .AddTransient<IPrimeNumberService, PrimeNumberService>();
        }
    }
}
