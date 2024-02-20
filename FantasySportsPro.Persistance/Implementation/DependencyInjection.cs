using FantasySportsPro.Persistance.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FantasySportsPro.Persistence.Tests")]
namespace FantasySportsPro.Persistance.Implementation
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectPersistenceDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IDbConnectionFactory>(new DbConnectionFactory(connectionString));
            services.AddScoped<IDataAccess, DataAccess>();

            return services;
        }
    }
}
