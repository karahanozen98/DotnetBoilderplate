using DotnetBoilerplate.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetBoilerplate.Application.Extensions
{
    public static class BuilderExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();
            return services;
        }
    }
}