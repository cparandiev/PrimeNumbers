using Microsoft.Extensions.DependencyInjection;
using PrimeNumbers.Application.Interfaces;

namespace PrimeNumbers.Toolbox.Extensions
{
    public static class DependencyRegistrationExtensions
    {
        public static IServiceCollection RegisterPrimerNumbersToolboxDependencies(this IServiceCollection services)
        {
            return services
                .AddTransient<IPrimeNumberChecker, PrimeNumberChecker>()
                .AddTransient<IPrimeNumberGenerator, PrimeNumberGenerator>();
        }
    }
}
