using DotnetBoilerplate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetBoilerplate.Infrastructure.Extensions
{
    public static class BuilderExtension
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<DataSeeder>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var dbName = config.GetRequiredSection("ConnectionStrings:Main")?.Value;
                options.UseInMemoryDatabase(dbName ?? throw new Exception("Please provide the Database name"));
            });

            return services;
        }
    }
}