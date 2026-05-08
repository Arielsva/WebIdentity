using System.Net.NetworkInformation;
using WebIdentity.Data;

namespace WebIdentity.Configuration
{
    public static class DepedencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();

            return services;
        }
    }
}
