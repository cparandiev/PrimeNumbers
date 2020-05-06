using Microsoft.Extensions.DependencyInjection;
using PrimeNumbers.Application.Common.Interfaces;

namespace PrimeNumbers.Toolbox.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterPrimerNumbersToolboxDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPrimeNumberChecker, PrimeNumberChecker>();
            services.AddTransient<IPrimeNumberGenerator, PrimeNumberGenerator>();

            return services;
        }
    }
}