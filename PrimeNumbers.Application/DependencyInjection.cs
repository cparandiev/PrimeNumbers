using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using PrimeNumbers.Application.Common.Behaviours;
using MediatR;

namespace PrimeNumbers.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplicationDependencies(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}
