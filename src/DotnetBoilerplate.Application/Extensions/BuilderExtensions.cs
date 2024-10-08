using Microsoft.Extensions.DependencyInjection;

namespace DotnetBoilerplate.Application.Extensions
{
    public static class BuilderExtension
    {
        public static IServiceCollection AddCQRS(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(BuilderExtension).Assembly);
            });

            return services;
        }
    }
}